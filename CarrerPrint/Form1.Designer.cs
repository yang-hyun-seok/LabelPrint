namespace CarrerPrint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdisp = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_L_UP_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_L_UP_Y = new System.Windows.Forms.TextBox();
            this.txt_L_UP_FN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_R_UP_FN = new System.Windows.Forms.TextBox();
            this.txt_R_UP_Y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_R_UP_X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_L_DOWN_FN = new System.Windows.Forms.TextBox();
            this.txt_L_DOWN_Y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_L_DOWN_X = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_R_DOWN_FN = new System.Windows.Forms.TextBox();
            this.txt_R_DOWN_Y = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_R_DOWN_X = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_L_UP_FN);
            this.groupBox1.Controls.Add(this.txt_L_UP_Y);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_L_UP_X);
            this.groupBox1.Controls.Add(this.txt_line);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "좌 상단";
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_line.Location = new System.Drawing.Point(16, 55);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(121, 32);
            this.txt_line.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_L_DOWN_FN);
            this.groupBox2.Controls.Add(this.txt_L_DOWN_Y);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_L_DOWN_X);
            this.groupBox2.Controls.Add(this.txtPoint);
            this.groupBox2.Location = new System.Drawing.Point(14, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좌 하단";
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPoint.Location = new System.Drawing.Point(16, 67);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(121, 32);
            this.txtPoint.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_R_DOWN_FN);
            this.groupBox3.Controls.Add(this.txt_R_DOWN_Y);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_R_DOWN_X);
            this.groupBox3.Controls.Add(this.txtdisp);
            this.groupBox3.Location = new System.Drawing.Point(275, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "우 하단";
            // 
            // txtdisp
            // 
            this.txtdisp.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtdisp.Location = new System.Drawing.Point(18, 67);
            this.txtdisp.Name = "txtdisp";
            this.txtdisp.Size = new System.Drawing.Size(228, 32);
            this.txtdisp.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtCarrier);
            this.groupBox4.Controls.Add(this.txt_R_UP_FN);
            this.groupBox4.Controls.Add(this.txt_R_UP_Y);
            this.groupBox4.Controls.Add(this.txt_R_UP_X);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(275, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 99);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "우 상단";
            // 
            // txtCarrier
            // 
            this.txtCarrier.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCarrier.Location = new System.Drawing.Point(19, 55);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(228, 32);
            this.txtCarrier.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "프린트";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_L_UP_X
            // 
            this.txt_L_UP_X.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_UP_X.Location = new System.Drawing.Point(34, 22);
            this.txt_L_UP_X.Name = "txt_L_UP_X";
            this.txt_L_UP_X.Size = new System.Drawing.Size(38, 20);
            this.txt_L_UP_X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // txt_L_UP_Y
            // 
            this.txt_L_UP_Y.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_UP_Y.Location = new System.Drawing.Point(104, 22);
            this.txt_L_UP_Y.Name = "txt_L_UP_Y";
            this.txt_L_UP_Y.Size = new System.Drawing.Size(38, 20);
            this.txt_L_UP_Y.TabIndex = 4;
            // 
            // txt_L_UP_FN
            // 
            this.txt_L_UP_FN.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_UP_FN.Location = new System.Drawing.Point(203, 22);
            this.txt_L_UP_FN.Name = "txt_L_UP_FN";
            this.txt_L_UP_FN.Size = new System.Drawing.Size(38, 20);
            this.txt_L_UP_FN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "F_Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "F_Size:";
            // 
            // txt_R_UP_FN
            // 
            this.txt_R_UP_FN.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_UP_FN.Location = new System.Drawing.Point(208, 18);
            this.txt_R_UP_FN.Name = "txt_R_UP_FN";
            this.txt_R_UP_FN.Size = new System.Drawing.Size(38, 20);
            this.txt_R_UP_FN.TabIndex = 11;
            // 
            // txt_R_UP_Y
            // 
            this.txt_R_UP_Y.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_UP_Y.Location = new System.Drawing.Point(109, 18);
            this.txt_R_UP_Y.Name = "txt_R_UP_Y";
            this.txt_R_UP_Y.Size = new System.Drawing.Size(38, 20);
            this.txt_R_UP_Y.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "X:";
            // 
            // txt_R_UP_X
            // 
            this.txt_R_UP_X.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_UP_X.Location = new System.Drawing.Point(39, 18);
            this.txt_R_UP_X.Name = "txt_R_UP_X";
            this.txt_R_UP_X.Size = new System.Drawing.Size(38, 20);
            this.txt_R_UP_X.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "F_Size:";
            // 
            // txt_L_DOWN_FN
            // 
            this.txt_L_DOWN_FN.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_DOWN_FN.Location = new System.Drawing.Point(203, 20);
            this.txt_L_DOWN_FN.Name = "txt_L_DOWN_FN";
            this.txt_L_DOWN_FN.Size = new System.Drawing.Size(38, 20);
            this.txt_L_DOWN_FN.TabIndex = 11;
            // 
            // txt_L_DOWN_Y
            // 
            this.txt_L_DOWN_Y.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_DOWN_Y.Location = new System.Drawing.Point(104, 20);
            this.txt_L_DOWN_Y.Name = "txt_L_DOWN_Y";
            this.txt_L_DOWN_Y.Size = new System.Drawing.Size(38, 20);
            this.txt_L_DOWN_Y.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "X:";
            // 
            // txt_L_DOWN_X
            // 
            this.txt_L_DOWN_X.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_L_DOWN_X.Location = new System.Drawing.Point(34, 20);
            this.txt_L_DOWN_X.Name = "txt_L_DOWN_X";
            this.txt_L_DOWN_X.Size = new System.Drawing.Size(38, 20);
            this.txt_L_DOWN_X.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "F_Size:";
            // 
            // txt_R_DOWN_FN
            // 
            this.txt_R_DOWN_FN.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_DOWN_FN.Location = new System.Drawing.Point(208, 24);
            this.txt_R_DOWN_FN.Name = "txt_R_DOWN_FN";
            this.txt_R_DOWN_FN.Size = new System.Drawing.Size(38, 20);
            this.txt_R_DOWN_FN.TabIndex = 11;
            // 
            // txt_R_DOWN_Y
            // 
            this.txt_R_DOWN_Y.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_DOWN_Y.Location = new System.Drawing.Point(109, 24);
            this.txt_R_DOWN_Y.Name = "txt_R_DOWN_Y";
            this.txt_R_DOWN_Y.Size = new System.Drawing.Size(38, 20);
            this.txt_R_DOWN_Y.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "X:";
            // 
            // txt_R_DOWN_X
            // 
            this.txt_R_DOWN_X.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_R_DOWN_X.Location = new System.Drawing.Point(39, 24);
            this.txt_R_DOWN_X.Name = "txt_R_DOWN_X";
            this.txt_R_DOWN_X.Size = new System.Drawing.Size(38, 20);
            this.txt_R_DOWN_X.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4칸 라벨 프린트";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtdisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_L_UP_FN;
        private System.Windows.Forms.TextBox txt_L_UP_Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_L_UP_X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_L_DOWN_FN;
        private System.Windows.Forms.TextBox txt_L_DOWN_Y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_L_DOWN_X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_R_DOWN_FN;
        private System.Windows.Forms.TextBox txt_R_DOWN_Y;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_R_DOWN_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_R_UP_FN;
        private System.Windows.Forms.TextBox txt_R_UP_Y;
        private System.Windows.Forms.TextBox txt_R_UP_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

