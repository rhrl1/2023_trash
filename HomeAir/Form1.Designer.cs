namespace HomeAir
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoom1 = new System.Windows.Forms.Label();
            this.lblDust1 = new System.Windows.Forms.Label();
            this.lblDust2 = new System.Windows.Forms.Label();
            this.lblLiviDust = new System.Windows.Forms.Label();
            this.lblLiving = new System.Windows.Forms.Label();
            this.lblRoom2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHumi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(176, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "실내 미세먼지 모니터링";
            // 
            // lblRoom1
            // 
            this.lblRoom1.AutoSize = true;
            this.lblRoom1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoom1.Location = new System.Drawing.Point(120, 462);
            this.lblRoom1.Name = "lblRoom1";
            this.lblRoom1.Size = new System.Drawing.Size(28, 17);
            this.lblRoom1.TabIndex = 2;
            this.lblRoom1.Text = "방1";
            // 
            // lblDust1
            // 
            this.lblDust1.AutoSize = true;
            this.lblDust1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDust1.Location = new System.Drawing.Point(77, 506);
            this.lblDust1.Name = "lblDust1";
            this.lblDust1.Size = new System.Drawing.Size(119, 15);
            this.lblDust1.TabIndex = 3;
            this.lblDust1.Text = "미세먼지:      ug/m3";
            // 
            // lblDust2
            // 
            this.lblDust2.AutoSize = true;
            this.lblDust2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDust2.Location = new System.Drawing.Point(479, 506);
            this.lblDust2.Name = "lblDust2";
            this.lblDust2.Size = new System.Drawing.Size(119, 15);
            this.lblDust2.TabIndex = 4;
            this.lblDust2.Text = "미세먼지:      ug/m3";
            // 
            // lblLiviDust
            // 
            this.lblLiviDust.AutoSize = true;
            this.lblLiviDust.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLiviDust.Location = new System.Drawing.Point(267, 506);
            this.lblLiviDust.Name = "lblLiviDust";
            this.lblLiviDust.Size = new System.Drawing.Size(119, 15);
            this.lblLiviDust.TabIndex = 5;
            this.lblLiviDust.Text = "미세먼지:      ug/m3";
            // 
            // lblLiving
            // 
            this.lblLiving.AutoSize = true;
            this.lblLiving.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLiving.Location = new System.Drawing.Point(314, 462);
            this.lblLiving.Name = "lblLiving";
            this.lblLiving.Size = new System.Drawing.Size(34, 17);
            this.lblLiving.TabIndex = 6;
            this.lblLiving.Text = "거실";
            // 
            // lblRoom2
            // 
            this.lblRoom2.AutoSize = true;
            this.lblRoom2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoom2.Location = new System.Drawing.Point(518, 462);
            this.lblRoom2.Name = "lblRoom2";
            this.lblRoom2.Size = new System.Drawing.Size(28, 17);
            this.lblRoom2.TabIndex = 7;
            this.lblRoom2.Text = "방2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 8;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp.Location = new System.Drawing.Point(38, 131);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(70, 15);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "실내 온도 : ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(541, 134);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 12);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "현재 시간";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Form2 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeAir.Properties.Resources.평면도_1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHumi
            // 
            this.lblHumi.AutoSize = true;
            this.lblHumi.Location = new System.Drawing.Point(150, 133);
            this.lblHumi.Name = "lblHumi";
            this.lblHumi.Size = new System.Drawing.Size(69, 12);
            this.lblHumi.TabIndex = 13;
            this.lblHumi.Text = "실내 습도 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 631);
            this.Controls.Add(this.lblHumi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRoom2);
            this.Controls.Add(this.lblLiving);
            this.Controls.Add(this.lblLiviDust);
            this.Controls.Add(this.lblDust2);
            this.Controls.Add(this.lblDust1);
            this.Controls.Add(this.lblRoom1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "실내 미세먼지 모니터링";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoom1;
        private System.Windows.Forms.Label lblDust1;
        private System.Windows.Forms.Label lblDust2;
        private System.Windows.Forms.Label lblLiviDust;
        private System.Windows.Forms.Label lblLiving;
        private System.Windows.Forms.Label lblRoom2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHumi;
    }
}

