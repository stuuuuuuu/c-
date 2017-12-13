namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.串口设置 = new System.Windows.Forms.GroupBox();
            this.txtRcv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.cbHbr = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.串口设置.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // 串口设置
            // 
            this.串口设置.Controls.Add(this.txtRcv);
            this.串口设置.Location = new System.Drawing.Point(51, 179);
            this.串口设置.Name = "串口设置";
            this.串口设置.Size = new System.Drawing.Size(511, 91);
            this.串口设置.TabIndex = 0;
            this.串口设置.TabStop = false;
            this.串口设置.Text = "数据接收";
            // 
            // txtRcv
            // 
            this.txtRcv.Location = new System.Drawing.Point(9, 20);
            this.txtRcv.Multiline = true;
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.ReadOnly = true;
            this.txtRcv.Size = new System.Drawing.Size(497, 55);
            this.txtRcv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbState);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbHbr);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbStop);
            this.groupBox1.Controls.Add(this.cbDataBits);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.cbSerial);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbRcvStr);
            this.groupBox4.Controls.Add(this.rbRcv16);
            this.groupBox4.Location = new System.Drawing.Point(9, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 47);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Checked = true;
            this.rbRcvStr.Location = new System.Drawing.Point(99, 20);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 17;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(6, 20);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 18;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            this.rbRcv16.CheckedChanged += new System.EventHandler(this.rbRcv16_CheckedChanged);
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(55, 78);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(100, 20);
            this.cbStop.TabIndex = 16;
            this.cbStop.SelectedIndexChanged += new System.EventHandler(this.cbStop_SelectedIndexChanged);
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(226, 59);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(100, 20);
            this.cbDataBits.TabIndex = 15;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(55, 53);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(100, 20);
            this.cbBaudRate.TabIndex = 14;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // cbSerial
            // 
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(55, 24);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(100, 20);
            this.cbSerial.TabIndex = 13;
            this.cbSerial.SelectedIndexChanged += new System.EventHandler(this.cbSerial_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(226, 26);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(100, 20);
            this.cbParity.TabIndex = 12;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "串口检测";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OpenPort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "波特率:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "奇偶校验:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.txtSend);
            this.groupBox2.Location = new System.Drawing.Point(51, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据发送";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(313, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清空数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(394, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(9, 20);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(298, 39);
            this.txtSend.TabIndex = 1;
            // 
            // cbHbr
            // 
            this.cbHbr.AutoSize = true;
            this.cbHbr.Location = new System.Drawing.Point(198, 137);
            this.cbHbr.Name = "cbHbr";
            this.cbHbr.Size = new System.Drawing.Size(71, 16);
            this.cbHbr.TabIndex = 22;
            this.cbHbr.Text = "自动换行";
            this.cbHbr.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "串口状态：";
            // 
            // cbState
            // 
            this.cbState.AutoSize = true;
            this.cbState.Location = new System.Drawing.Point(418, 59);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(29, 12);
            this.cbState.TabIndex = 24;
            this.cbState.Text = "关闭";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.串口设置);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.串口设置.ResumeLayout(false);
            this.串口设置.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 串口设置;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRcv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton cbHbr;
        private System.Windows.Forms.Label cbState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

