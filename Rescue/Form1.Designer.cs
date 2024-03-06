namespace Rescue
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button tcpConnect;
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reload1 = new System.Windows.Forms.Button();
            this.url1Enter = new System.Windows.Forms.Button();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.reload2 = new System.Windows.Forms.Button();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.outputLineCount = new System.Windows.Forms.TextBox();
            tcpConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcpConnect
            // 
            tcpConnect.Location = new System.Drawing.Point(1448, 440);
            tcpConnect.Name = "tcpConnect";
            tcpConnect.Size = new System.Drawing.Size(84, 23);
            tcpConnect.TabIndex = 13;
            tcpConnect.Text = "Connect";
            tcpConnect.UseVisualStyleBackColor = true;
            tcpConnect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 82);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1056, 715);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1056, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Camera_1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1080, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(831, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Camera_2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reload1
            // 
            this.reload1.Location = new System.Drawing.Point(16, 47);
            this.reload1.Margin = new System.Windows.Forms.Padding(4);
            this.reload1.Name = "reload1";
            this.reload1.Size = new System.Drawing.Size(65, 28);
            this.reload1.TabIndex = 4;
            this.reload1.Text = "Reload";
            this.reload1.UseVisualStyleBackColor = true;
            this.reload1.Click += new System.EventHandler(this.button1_Click);
            // 
            // url1Enter
            // 
            this.url1Enter.Location = new System.Drawing.Point(1007, 47);
            this.url1Enter.Margin = new System.Windows.Forms.Padding(4);
            this.url1Enter.Name = "url1Enter";
            this.url1Enter.Size = new System.Drawing.Size(65, 28);
            this.url1Enter.TabIndex = 5;
            this.url1Enter.Text = "Enter";
            this.url1Enter.UseVisualStyleBackColor = true;
            this.url1Enter.Click += new System.EventHandler(this.url1Enter_Click);
            // 
            // txtUrl1
            // 
            this.txtUrl1.Location = new System.Drawing.Point(91, 49);
            this.txtUrl1.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(907, 22);
            this.txtUrl1.TabIndex = 6;
            // 
            // reload2
            // 
            this.reload2.Location = new System.Drawing.Point(1080, 47);
            this.reload2.Margin = new System.Windows.Forms.Padding(4);
            this.reload2.Name = "reload2";
            this.reload2.Size = new System.Drawing.Size(65, 28);
            this.reload2.TabIndex = 7;
            this.reload2.Text = "Reload";
            this.reload2.UseVisualStyleBackColor = true;
            this.reload2.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(1153, 49);
            this.txtUrl2.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(685, 22);
            this.txtUrl2.TabIndex = 8;
            this.txtUrl2.TextChanged += new System.EventHandler(this.txtUrl2_TextChanged);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(1846, 49);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(1080, 81);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(831, 315);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(1082, 468);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(450, 219);
            this.output.TabIndex = 10;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1079, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Connect to Arduino TCP Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(1153, 440);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(289, 22);
            this.ipAddress.TabIndex = 14;
            this.ipAddress.Text = "192.168.158.215";
            this.ipAddress.TextChanged += new System.EventHandler(this.ipAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1077, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "IP Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 804);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Connect Controller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1082, 693);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputLineCount
            // 
            this.outputLineCount.Location = new System.Drawing.Point(1432, 710);
            this.outputLineCount.Name = "outputLineCount";
            this.outputLineCount.ReadOnly = true;
            this.outputLineCount.Size = new System.Drawing.Size(100, 22);
            this.outputLineCount.TabIndex = 20;
            this.outputLineCount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.outputLineCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(tcpConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.reload2);
            this.Controls.Add(this.txtUrl1);
            this.Controls.Add(this.url1Enter);
            this.Controls.Add(this.reload1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button reload1;
        private System.Windows.Forms.Button url1Enter;
        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.Button reload2;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outputLineCount;
    }
}

