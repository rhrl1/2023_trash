using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Moniter : Form
    {
        Form1 f;
        public Moniter(Form1 form)
        {
            InitializeComponent();
            f = form;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form1의 측정값을 불러오기 (Modifiers 속성 public)
            lblHumi.Text = f.label2.Text;
            lblTemp.Text= f.label3.Text;
            label6.Text = f.label4.Text;

            // 거실
            lblLiving.Text = f.label6.Text;
            label2.Text = f.label8.Text;
            label5.Text = f.label7.Text;

            //방2
            label7.Text = f.label10.Text;
            label3.Text = f.label12.Text;
            label10.Text = f.label11.Text;
        }
    }
}
