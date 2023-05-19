using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // IO 포트를 위한 참조

namespace HomeAir
{
    public partial class Form2 : Form
    {
        private SerialPort myport; // 포트를 가져온다.
        private string in_data;    // 읽을 값을 저장하는 데이터
        private string Humi;       // 습도 변수 생성
        private string Temp;       // 온도 변수 생성

        public Form2()
        {
            InitializeComponent();
        }
        private void btnStart1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;              // 통신 속도 지정
            myport.PortName = txtPort1.Text;     // 포트 이름을 텍스트 박스에 넣는다
            myport.Parity = Parity.None;         // 
            myport.DataBits = 8;                 // 사용되는 비트수 8비트
            myport.StopBits = StopBits.One;      // 비트 정지는 1
            myport.DataReceived += myport_DataReceived; // 데이터 담을 연산자 사용

            try
            {
                myport.Open();
                listView1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadLine();       // 출력되는 데이터 읽음
            Humi = in_data.Substring(0, 16);   // 습도값 읽은 string 데이터를 잘라서 구분
            Temp = in_data.Substring(16);      // 온도값

            this.Invoke(new EventHandler(displaydata_event));  // 크로스 스레드 방지
        }
        private void displaydata_event(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();   // 리스트뷰 생성자
            lvi.Text = DateTime.Now.ToString();
            lvi.SubItems.Add(Humi);                  // 습도 변수에 저장 컬럼 단위로 추가
            lvi.SubItems.Add(Temp);                  // 온도 변수에 저장
            listView1.Items.Add(lvi);                // 변수 저장된 데이터 추가
            listView1.EnsureVisible(listView1.Items.Count - 1);  // 새로 받아오는 데이터가 넘치면 자동 스크롤 됨
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

    }
}
