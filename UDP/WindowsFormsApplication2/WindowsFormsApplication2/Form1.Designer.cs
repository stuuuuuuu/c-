namespace WindowsFormsApplication2
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
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecMsg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.lkPort = new System.Windows.Forms.Label();
            this.lkIP = new System.Windows.Forms.Label();
            this.mbPort = new System.Windows.Forms.TextBox();
            this.mbIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(488, 74);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 21);
            this.tbIP.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(488, 131);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号:";
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(488, 188);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(75, 23);
            this.Link.TabIndex = 4;
            this.Link.Text = "连接";
            this.Link.UseVisualStyleBackColor = true;
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecMsg);
            this.groupBox1.Location = new System.Drawing.Point(193, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收数据";
            // 
            // txtRecMsg
            // 
            this.txtRecMsg.Location = new System.Drawing.Point(3, 17);
            this.txtRecMsg.Multiline = true;
            this.txtRecMsg.Name = "txtRecMsg";
            this.txtRecMsg.Size = new System.Drawing.Size(249, 150);
            this.txtRecMsg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSendMsg);
            this.groupBox2.Location = new System.Drawing.Point(193, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据";
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(6, 20);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(240, 54);
            this.txtSendMsg.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(488, 274);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 8;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // lkPort
            // 
            this.lkPort.AutoSize = true;
            this.lkPort.Location = new System.Drawing.Point(40, 254);
            this.lkPort.Name = "lkPort";
            this.lkPort.Size = new System.Drawing.Size(71, 12);
            this.lkPort.TabIndex = 12;
            this.lkPort.Text = "目标端口号:";
            // 
            // lkIP
            // 
            this.lkIP.AutoSize = true;
            this.lkIP.Location = new System.Drawing.Point(40, 188);
            this.lkIP.Name = "lkIP";
            this.lkIP.Size = new System.Drawing.Size(71, 12);
            this.lkIP.TabIndex = 11;
            this.lkIP.Text = "目标IP地址:";
            // 
            // mbPort
            // 
            this.mbPort.Location = new System.Drawing.Point(42, 269);
            this.mbPort.Name = "mbPort";
            this.mbPort.Size = new System.Drawing.Size(100, 21);
            this.mbPort.TabIndex = 10;
            // 
            // mbIP
            // 
            this.mbIP.Location = new System.Drawing.Point(42, 212);
            this.mbIP.Name = "mbIP";
            this.mbIP.Size = new System.Drawing.Size(100, 21);
            this.mbIP.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 360);
            this.Controls.Add(this.lkPort);
            this.Controls.Add(this.lkIP);
            this.Controls.Add(this.mbPort);
            this.Controls.Add(this.mbIP);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label lkPort;
        private System.Windows.Forms.Label lkIP;
        private System.Windows.Forms.TextBox mbPort;
        private System.Windows.Forms.TextBox mbIP;
    }
}

