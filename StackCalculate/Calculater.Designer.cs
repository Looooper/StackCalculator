namespace StackCalculate
{
    partial class Calculater
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtbxStackStatus = new System.Windows.Forms.RichTextBox();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 141);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(152, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 64);
            this.button7.TabIndex = 9;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(82, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 64);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 211);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 64);
            this.button9.TabIndex = 7;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AppendDigit);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(152, 281);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(134, 64);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(82, 281);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 64);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(292, 281);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 64);
            this.button13.TabIndex = 16;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.PerformOperate);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(292, 211);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 64);
            this.button14.TabIndex = 15;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.PerformOperate);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(292, 141);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 64);
            this.button15.TabIndex = 14;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.PerformOperate);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(292, 71);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 64);
            this.button16.TabIndex = 13;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.PerformOperate);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(222, 211);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 64);
            this.button12.TabIndex = 10;
            this.button12.Text = "Sqrt";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.PerformOperate);
            // 
            // tbxResult
            // 
            this.tbxResult.Font = new System.Drawing.Font("宋体", 20F);
            this.tbxResult.Location = new System.Drawing.Point(13, 12);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(463, 38);
            this.tbxResult.TabIndex = 17;
            this.tbxResult.Text = "0";
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(362, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 12);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "栈状态";
            // 
            // rtbxStackStatus
            // 
            this.rtbxStackStatus.Location = new System.Drawing.Point(362, 89);
            this.rtbxStackStatus.Name = "rtbxStackStatus";
            this.rtbxStackStatus.Size = new System.Drawing.Size(114, 256);
            this.rtbxStackStatus.TabIndex = 19;
            this.rtbxStackStatus.Text = "";
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(222, 141);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(64, 64);
            this.btnAC.TabIndex = 20;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(222, 71);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 64);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 355);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.rtbxStackStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculater";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Calculater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtbxStackStatus;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnC;
    }
}

