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
            this.tbxlocalip = new System.Windows.Forms.TextBox();
            this.tbxSendtoIp = new System.Windows.Forms.TextBox();
            this.tbxSendtoport = new System.Windows.Forms.TextBox();
            this.tbxlocalPort = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMessageSend = new System.Windows.Forms.TextBox();
            this.chkbxAnonymous = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxlocalip
            // 
            this.tbxlocalip.Location = new System.Drawing.Point(112, 12);
            this.tbxlocalip.Name = "tbxlocalip";
            this.tbxlocalip.Size = new System.Drawing.Size(100, 21);
            this.tbxlocalip.TabIndex = 1;
            // 
            // tbxSendtoIp
            // 
            this.tbxSendtoIp.Location = new System.Drawing.Point(112, 60);
            this.tbxSendtoIp.Name = "tbxSendtoIp";
            this.tbxSendtoIp.Size = new System.Drawing.Size(100, 21);
            this.tbxSendtoIp.TabIndex = 2;
            // 
            // tbxSendtoport
            // 
            this.tbxSendtoport.Location = new System.Drawing.Point(348, 60);
            this.tbxSendtoport.Name = "tbxSendtoport";
            this.tbxSendtoport.Size = new System.Drawing.Size(50, 21);
            this.tbxSendtoport.TabIndex = 4;
            // 
            // tbxlocalPort
            // 
            this.tbxlocalPort.Location = new System.Drawing.Point(348, 12);
            this.tbxlocalPort.Name = "tbxlocalPort";
            this.tbxlocalPort.Size = new System.Drawing.Size(50, 21);
            this.tbxlocalPort.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清零";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(467, 93);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(50, 23);
            this.btnReceive.TabIndex = 8;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click_1);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(411, 93);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // tbxMessageSend
            // 
            this.tbxMessageSend.Location = new System.Drawing.Point(167, 135);
            this.tbxMessageSend.Name = "tbxMessageSend";
            this.tbxMessageSend.Size = new System.Drawing.Size(324, 21);
            this.tbxMessageSend.TabIndex = 9;
            // 
            // chkbxAnonymous
            // 
            this.chkbxAnonymous.AutoSize = true;
            this.chkbxAnonymous.Location = new System.Drawing.Point(38, 93);
            this.chkbxAnonymous.Name = "chkbxAnonymous";
            this.chkbxAnonymous.Size = new System.Drawing.Size(48, 16);
            this.chkbxAnonymous.TabIndex = 11;
            this.chkbxAnonymous.Text = "匿名";
            this.chkbxAnonymous.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.ItemHeight = 12;
            this.listView1.Location = new System.Drawing.Point(167, 161);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 88);
            this.listView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chkbxAnonymous);
            this.Controls.Add(this.tbxMessageSend);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxSendtoport);
            this.Controls.Add(this.tbxlocalPort);
            this.Controls.Add(this.tbxSendtoIp);
            this.Controls.Add(this.tbxlocalip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxlocalip;
        private System.Windows.Forms.TextBox tbxSendtoIp;
        private System.Windows.Forms.TextBox tbxSendtoport;
        private System.Windows.Forms.TextBox tbxlocalPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMessageSend;
        private System.Windows.Forms.CheckBox chkbxAnonymous;
        private System.Windows.Forms.ListBox listView1;
    }
}

