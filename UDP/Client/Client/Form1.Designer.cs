namespace Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRecv = new System.Windows.Forms.Button();
            this.txtSendMssg = new System.Windows.Forms.RichTextBox();
            this.txtRecvMssg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(96, 201);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRecv
            // 
            this.btnRecv.Location = new System.Drawing.Point(341, 201);
            this.btnRecv.Name = "btnRecv";
            this.btnRecv.Size = new System.Drawing.Size(75, 23);
            this.btnRecv.TabIndex = 3;
            this.btnRecv.Text = "receive";
            this.btnRecv.UseVisualStyleBackColor = true;
            this.btnRecv.Click += new System.EventHandler(this.btnRecv_Click);
            // 
            // txtSendMssg
            // 
            this.txtSendMssg.Location = new System.Drawing.Point(30, 12);
            this.txtSendMssg.Name = "txtSendMssg";
            this.txtSendMssg.Size = new System.Drawing.Size(215, 183);
            this.txtSendMssg.TabIndex = 4;
            this.txtSendMssg.Text = "";
            // 
            // txtRecvMssg
            // 
            this.txtRecvMssg.Location = new System.Drawing.Point(269, 12);
            this.txtRecvMssg.Name = "txtRecvMssg";
            this.txtRecvMssg.Size = new System.Drawing.Size(193, 183);
            this.txtRecvMssg.TabIndex = 5;
            this.txtRecvMssg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.txtRecvMssg);
            this.Controls.Add(this.txtSendMssg);
            this.Controls.Add(this.btnRecv);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRecv;
        private System.Windows.Forms.RichTextBox txtSendMssg;
        private System.Windows.Forms.RichTextBox txtRecvMssg;
    }
}

