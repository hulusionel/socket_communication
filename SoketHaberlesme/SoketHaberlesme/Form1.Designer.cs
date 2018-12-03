namespace SoketHaberlesme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtOwnIP = new System.Windows.Forms.TextBox();
            this.txtOwnPort = new System.Windows.Forms.TextBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(494, 399);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 399);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 46);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 197);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(599, 187);
            this.textBox2.TabIndex = 2;
            // 
            // txtOwnIP
            // 
            this.txtOwnIP.Location = new System.Drawing.Point(101, 30);
            this.txtOwnIP.Name = "txtOwnIP";
            this.txtOwnIP.Size = new System.Drawing.Size(100, 20);
            this.txtOwnIP.TabIndex = 3;
            // 
            // txtOwnPort
            // 
            this.txtOwnPort.Location = new System.Drawing.Point(390, 30);
            this.txtOwnPort.Name = "txtOwnPort";
            this.txtOwnPort.Size = new System.Drawing.Size(100, 20);
            this.txtOwnPort.TabIndex = 3;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(101, 113);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(100, 20);
            this.txtClientIP.TabIndex = 3;
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(390, 113);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(100, 20);
            this.txtClientPort.TabIndex = 3;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(42, 72);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(483, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(42, 158);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(483, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtOwnPort);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.txtOwnIP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtOwnIP;
        private System.Windows.Forms.TextBox txtOwnPort;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label6;
    }
}

