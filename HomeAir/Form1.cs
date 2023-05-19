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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f;       

        private void button1_Click(object sender, EventArgs e)
        {
            if(f == null)       // Form2 가 없을 때만 만든다
                f = new Form2();
            f.Show();
            
        }
    }
}
