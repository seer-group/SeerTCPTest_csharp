﻿namespace SeerTCPTest_csharp
{
    partial class MainForm
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
            this.groupBox_req = new System.Windows.Forms.GroupBox();
            this.textBox_head = new System.Windows.Forms.TextBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.groupBox_recv = new System.Windows.Forms.GroupBox();
            this.textBox_recv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_conn = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.groupBox_conn = new System.Windows.Forms.GroupBox();
            this.groupBox_req.SuspendLayout();
            this.groupBox_recv.SuspendLayout();
            this.groupBox_conn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_req
            // 
            this.groupBox_req.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_req.AutoSize = true;
            this.groupBox_req.Controls.Add(this.textBox_head);
            this.groupBox_req.Controls.Add(this.textBox_data);
            this.groupBox_req.Location = new System.Drawing.Point(12, 76);
            this.groupBox_req.Name = "groupBox_req";
            this.groupBox_req.Size = new System.Drawing.Size(603, 137);
            this.groupBox_req.TabIndex = 1;
            this.groupBox_req.TabStop = false;
            this.groupBox_req.Text = "请求";
            // 
            // textBox_head
            // 
            this.textBox_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_head.Location = new System.Drawing.Point(6, 24);
            this.textBox_head.Name = "textBox_head";
            this.textBox_head.Size = new System.Drawing.Size(588, 25);
            this.textBox_head.TabIndex = 2;
            // 
            // textBox_data
            // 
            this.textBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_data.Location = new System.Drawing.Point(6, 50);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_data.Size = new System.Drawing.Size(588, 79);
            this.textBox_data.TabIndex = 1;
            // 
            // groupBox_recv
            // 
            this.groupBox_recv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_recv.AutoSize = true;
            this.groupBox_recv.Controls.Add(this.textBox_recv);
            this.groupBox_recv.Location = new System.Drawing.Point(12, 219);
            this.groupBox_recv.Name = "groupBox_recv";
            this.groupBox_recv.Size = new System.Drawing.Size(603, 460);
            this.groupBox_recv.TabIndex = 2;
            this.groupBox_recv.TabStop = false;
            this.groupBox_recv.Text = "响应";
            // 
            // textBox_recv
            // 
            this.textBox_recv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recv.Location = new System.Drawing.Point(6, 20);
            this.textBox_recv.Multiline = true;
            this.textBox_recv.Name = "textBox_recv";
            this.textBox_recv.ReadOnly = true;
            this.textBox_recv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recv.Size = new System.Drawing.Size(588, 432);
            this.textBox_recv.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(6, 27);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(154, 25);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.Text = "127.0.0.1";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(167, 27);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(58, 25);
            this.textBox_port.TabIndex = 2;
            this.textBox_port.Text = "19204";
            // 
            // button_conn
            // 
            this.button_conn.Location = new System.Drawing.Point(231, 26);
            this.button_conn.Name = "button_conn";
            this.button_conn.Size = new System.Drawing.Size(75, 23);
            this.button_conn.TabIndex = 4;
            this.button_conn.Text = "连接";
            this.button_conn.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(331, 26);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // groupBox_conn
            // 
            this.groupBox_conn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_conn.AutoSize = true;
            this.groupBox_conn.Controls.Add(this.button_send);
            this.groupBox_conn.Controls.Add(this.button_conn);
            this.groupBox_conn.Controls.Add(this.textBox_port);
            this.groupBox_conn.Controls.Add(this.textBox_ip);
            this.groupBox_conn.Controls.Add(this.label3);
            this.groupBox_conn.Location = new System.Drawing.Point(12, 12);
            this.groupBox_conn.Name = "groupBox_conn";
            this.groupBox_conn.Size = new System.Drawing.Size(603, 76);
            this.groupBox_conn.TabIndex = 0;
            this.groupBox_conn.TabStop = false;
            this.groupBox_conn.Text = "连接";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(627, 691);
            this.Controls.Add(this.groupBox_recv);
            this.Controls.Add(this.groupBox_req);
            this.Controls.Add(this.groupBox_conn);
            this.Name = "MainForm";
            this.Text = "Seer Robotics Tcp Demo (C#)";
            this.groupBox_req.ResumeLayout(false);
            this.groupBox_req.PerformLayout();
            this.groupBox_recv.ResumeLayout(false);
            this.groupBox_recv.PerformLayout();
            this.groupBox_conn.ResumeLayout(false);
            this.groupBox_conn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_req;
        private System.Windows.Forms.GroupBox groupBox_recv;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.TextBox textBox_recv;
        private System.Windows.Forms.TextBox textBox_head;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_conn;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.GroupBox groupBox_conn;
    }
}
