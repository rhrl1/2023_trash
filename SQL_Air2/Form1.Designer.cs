namespace SQL_Air
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblPM10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblAvgPM = new System.Windows.Forms.Label();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnAutoLoad = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutoLoadEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(51, 37);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(62, 12);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "COM 포트";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(138, 34);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(272, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(368, 32);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "해제";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblPM10
            // 
            this.lblPM10.AutoSize = true;
            this.lblPM10.Location = new System.Drawing.Point(51, 90);
            this.lblPM10.Name = "lblPM10";
            this.lblPM10.Size = new System.Drawing.Size(144, 12);
            this.lblPM10.TabIndex = 4;
            this.lblPM10.Text = "미세먼지 농도 : - mg/m3";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 266);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "num";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "미세먼지 농도";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "시간";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "습도(Humi)";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "온도(Temp)";
            this.columnHeader5.Width = 101;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(46, 494);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAvgPM
            // 
            this.lblAvgPM.AutoSize = true;
            this.lblAvgPM.Location = new System.Drawing.Point(379, 90);
            this.lblAvgPM.Name = "lblAvgPM";
            this.lblAvgPM.Size = new System.Drawing.Size(116, 12);
            this.lblAvgPM.TabIndex = 7;
            this.lblAvgPM.Text = "평균농도 : - mg/m3";
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(146, 494);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(170, 23);
            this.btnCSV.TabIndex = 8;
            this.btnCSV.Text = "csv파일로 내보내기";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAutoLoad
            // 
            this.btnAutoLoad.Location = new System.Drawing.Point(46, 533);
            this.btnAutoLoad.Name = "btnAutoLoad";
            this.btnAutoLoad.Size = new System.Drawing.Size(121, 23);
            this.btnAutoLoad.TabIndex = 9;
            this.btnAutoLoad.Text = "자동 불러오기 시작";
            this.btnAutoLoad.UseVisualStyleBackColor = true;
            this.btnAutoLoad.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutoLoadEnd
            // 
            this.btnAutoLoadEnd.Location = new System.Drawing.Point(184, 533);
            this.btnAutoLoadEnd.Name = "btnAutoLoadEnd";
            this.btnAutoLoadEnd.Size = new System.Drawing.Size(121, 23);
            this.btnAutoLoadEnd.TabIndex = 10;
            this.btnAutoLoadEnd.Text = "자동 불러오기 종료";
            this.btnAutoLoadEnd.UseVisualStyleBackColor = true;
            this.btnAutoLoadEnd.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(596, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "복사본";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(51, 159);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(63, 12);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "온도 : - ℃";
            // 
            // lblHumi
            // 
            this.lblHumi.AutoSize = true;
            this.lblHumi.Location = new System.Drawing.Point(51, 124);
            this.lblHumi.Name = "lblHumi";
            this.lblHumi.Size = new System.Drawing.Size(61, 12);
            this.lblHumi.TabIndex = 13;
            this.lblHumi.Text = "습도 : - %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.lblHumi);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAutoLoadEnd);
            this.Controls.Add(this.btnAutoLoad);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.lblAvgPM);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblPM10);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPM10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblAvgPM;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnAutoLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAutoLoadEnd;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumi;
    }
}

