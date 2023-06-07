using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_Air  //복사본
{
    public partial class Form1 : Form
    {
        string Conn = "Server=localhost;Database=example121;Uid=root;Pwd=0000;";
        public Form1()
        {
            InitializeComponent();
        }

        // btn Connect
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPort.Text == "")
                MessageBox.Show("포트입력!");
            else
            {
                serialPort1.PortName = txtPort.Text;
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }           
        }

        // btn DisConnect
        private void button2_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //아두이노가 뭔가 보내면 이녀석이 실행된다
            string dust = serialPort1.ReadLine().Replace(((char)13).ToString(), "");    //.Replace("\r", "").Replace("\n", "");
            string Humi = serialPort1.ReadLine().Replace(((char)13).ToString(), "");    // **** 3개 다 char13이 아닌것 같음..
            string Temp = serialPort1.ReadLine().Replace(((char)13).ToString(), "");

            lblPM10.Text = "미세먼지 농도 : " + dust + " mg/m3";
            lblHumi.Text = "습도 : " + Humi + " %";     // 2번째 form에 값을 옮길 예정 Two Forms 참고
            lblTemp.Text = "온도 : " + Temp + " ℃";    // 너도

            string date = DateTime.Now.ToString();

            // * 입력하는 구문 *
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                conn.Open();
                MySqlCommand msc = 
                    new MySqlCommand("insert into gp2y10(dust, date, humi, temp) " +
                    "values("+ dust +",'"+ date +"',"+ Humi +","+ Temp +")", conn);
                msc.ExecuteNonQuery();
            }   //desc = 역순으로 보여줌 mysql
        }

        // btn Load Data
        private void button3_Click(object sender, EventArgs e)
        {
            // * 출력하는 구문 *
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                DataSet ds = new DataSet();
                string sql = "select * from gp2y10 order by date desc limit 20";  // 교수님께 여쭤볼것*** 
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "gp2y10");

                // 버튼을 누를때마다 리스트뷰를 새로 그린다.
                listView1.Items.Clear();
                
                // 평균 초기값
                double dust_ave = 0;

                // 데이터셋의 전체 레코드를 순회하는 방법
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //리스트뷰에 하나의 레코드를 집어넣는 방법
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ds.Tables[0].Rows[i]["num"].ToString();

                    string dust = ds.Tables[0].Rows[i]["dust"].ToString();

                    dust_ave = dust_ave + double.Parse(dust);   //평균

                    lvi.SubItems.Add(dust);
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["date"].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["humi"].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["temp"].ToString());

                    listView1.Items.Add(lvi);
                }
                // 평균 농도 : -mg/m3
                lblAvgPM.Text = "평균 농도 :" + (dust_ave / ds.Tables[0].Rows.Count).ToString() + " mg/m3";
                // 나중에 이 값을 2번째 form에 옮길 예정 Two Forms 참고
            }
        }


        // btn CSV 파일로 변환
        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                string path = "./gp2y10.csv";
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    sw.WriteLine(listView1.Items[i].SubItems[0].Text + 
                        listView1.Items[i].SubItems[1].Text +
                        listView1.Items[i].SubItems[2].Text +
                        listView1.Items[i].SubItems[3].Text +
                        listView1.Items[i].SubItems[4].Text);
                    /*listView1.Items[i].SubItems[0].Text;
                    listView1.Items[i].SubItems[1].Text;
                    listView1.Items[i].SubItems[2].Text;
                    listView1.Items[i].SubItems[3].Text;
                    listView1.Items[i].SubItems[4].Text;
                    */
                }

                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();

            }
        }

        // btn Auto Load_Data
        private void button5_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Start();
            }
        }

        // btn Stop Auto Load_Data
        private void button6_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                timer1.Stop();
            }
        }

        // 타이머가 시작하면 LoadData 버튼과 같은 역할을 한다.
        private void timer1_Tick(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }
    }
}
