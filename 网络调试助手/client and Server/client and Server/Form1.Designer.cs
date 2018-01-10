namespace client_and_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcpStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnet = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbIpPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecMsg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcpStatus
            // 
            this.tcpStatus.FormattingEnabled = true;
            this.tcpStatus.Location = new System.Drawing.Point(270, 21);
            this.tcpStatus.Name = "tcpStatus";
            this.tcpStatus.Size = new System.Drawing.Size(121, 20);
            this.tcpStatus.TabIndex = 0;
            this.tcpStatus.SelectedIndexChanged += new System.EventHandler(this.tcpStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(268, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "协议类型:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(270, 66);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(121, 21);
            this.tbIP.TabIndex = 2;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(270, 116);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(121, 21);
            this.tbPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "本地IP地址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "本地端口号:";
            // 
            // btnConnet
            // 
            this.btnConnet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnet.BackgroundImage")));
            this.btnConnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnet.FlatAppearance.BorderSize = 0;
            this.btnConnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnet.Location = new System.Drawing.Point(272, 162);
            this.btnConnet.Name = "btnConnet";
            this.btnConnet.Size = new System.Drawing.Size(119, 23);
            this.btnConnet.TabIndex = 6;
            this.btnConnet.Text = "开始监听";
            this.btnConnet.UseVisualStyleBackColor = true;
            this.btnConnet.Click += new System.EventHandler(this.btnConnet_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(23, 245);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(185, 53);
            this.txtSendMsg.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSend.Location = new System.Drawing.Point(239, 245);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 40);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbIpPort
            // 
            this.cbIpPort.FormattingEnabled = true;
            this.cbIpPort.Location = new System.Drawing.Point(134, 302);
            this.cbIpPort.Name = "cbIpPort";
            this.cbIpPort.Size = new System.Drawing.Size(74, 20);
            this.cbIpPort.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(77, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "目标IP:";
            // 
            // txtRecMsg
            // 
            this.txtRecMsg.Location = new System.Drawing.Point(6, 17);
            this.txtRecMsg.Multiline = true;
            this.txtRecMsg.Name = "txtRecMsg";
            this.txtRecMsg.Size = new System.Drawing.Size(199, 173);
            this.txtRecMsg.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtRecMsg);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 218);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备数据接收";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbIpPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcpStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tcpStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnet;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbIpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecMsg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

