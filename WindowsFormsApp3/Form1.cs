using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("입력");
            else
            {
                serialPort1.PortName = textBox1.Text;
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rawdata = label2.Text = serialPort1.ReadLine();

            string[] data = rawdata.Split(',');

            label2.Text = "습도 : " + data[0] + "%";
            label3.Text = "온도 : " + data[1] + "'c";
            label4.Text = "미세먼지 : " + data[2]; // + "mg/m3"  //임시로 다른값

            string date = DateTime.Now.ToString();

            //리스트뷰
            ListViewItem lvi = new ListViewItem();            
            lvi.SubItems.Add(data[0]);  // 습도
            lvi.SubItems.Add(data[1]);  // 온도
            lvi.SubItems.Add(data[2]);  // 미세먼지
            lvi.Text = DateTime.Now.ToString();
            listView1.Items.Add(lvi);   //데이터 추가?
            listView1.EnsureVisible(listView1.Items.Count - 1); // 새로 받아오는 데이터 자동스크롤
        }

        Moniter f; // Form2 
        private void lblForm2_Click(object sender, EventArgs e)
        {            
            if(f== null)
               f = new Moniter(this);
            f.Show();
            
        }

        // 2
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("입력");
            else
            {
                serialPort2.PortName = textBox2.Text;
                if (serialPort2.IsOpen == false)
                {
                    serialPort2.Open();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen == true)
            {
                serialPort2.Close();
            }
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rawdata = label8.Text = serialPort2.ReadLine();

            string[] data = rawdata.Split(',');

            label8.Text = "습도 : " + data[0] + "%";
            label7.Text = "온도 : " + data[1] + "'c";
            label6.Text = "미세먼지 : " + data[2]; // + "mg/m3"  //임시로 다른값

            string date = DateTime.Now.ToString();

            //리스트뷰
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(data[0]);  // 습도
            lvi.SubItems.Add(data[1]);  // 온도
            lvi.SubItems.Add(data[2]);  // 미세먼지
            lvi.Text = DateTime.Now.ToString();
            listView2.Items.Add(lvi);   //데이터 추가?
            listView2.EnsureVisible(listView2.Items.Count - 1); // 새로 받아오는 데이터 자동스크롤
        }


        // 3
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("입력");
            else
            {
                serialPort3.PortName = textBox3.Text;
                if (serialPort3.IsOpen == false)
                {
                    serialPort3.Open();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen == true)
            {
                serialPort3.Close();
            }
        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rawdata = label12.Text = serialPort3.ReadLine();

            string[] data = rawdata.Split(',');

            label12.Text = "습도 : " + data[0] + "%";
            label11.Text = "온도 : " + data[1] + "'c";
            label10.Text = "미세먼지 : " + data[2]; // + "mg/m3"  //임시로 다른값

            string date = DateTime.Now.ToString();

            //리스트뷰
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(data[0]);  // 습도
            lvi.SubItems.Add(data[1]);  // 온도
            lvi.SubItems.Add(data[2]);  // 미세먼지
            lvi.Text = DateTime.Now.ToString();
            listView3.Items.Add(lvi);   //데이터 추가?
            listView3.EnsureVisible(listView3.Items.Count - 1); // 새로 받아오는 데이터 자동스크롤
        }
    }
    
}
