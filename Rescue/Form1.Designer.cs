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
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 67);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(792, 581);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(792, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Camera_1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(810, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Camera_2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reload1
            // 
            this.reload1.Location = new System.Drawing.Point(12, 38);
            this.reload1.Name = "reload1";
            this.reload1.Size = new System.Drawing.Size(49, 23);
            this.reload1.TabIndex = 4;
            this.reload1.Text = "Reload";
            this.reload1.UseVisualStyleBackColor = true;
            this.reload1.Click += new System.EventHandler(this.button1_Click);
            // 
            // url1Enter
            // 
            this.url1Enter.Location = new System.Drawing.Point(755, 38);
            this.url1Enter.Name = "url1Enter";
            this.url1Enter.Size = new System.Drawing.Size(49, 23);
            this.url1Enter.TabIndex = 5;
            this.url1Enter.Text = "Enter";
            this.url1Enter.UseVisualStyleBackColor = true;
            this.url1Enter.Click += new System.EventHandler(this.url1Enter_Click);
            // 
            // txtUrl1
            // 
            this.txtUrl1.Location = new System.Drawing.Point(68, 40);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(681, 20);
            this.txtUrl1.TabIndex = 6;
            // 
            // reload2
            // 
            this.reload2.Location = new System.Drawing.Point(810, 38);
            this.reload2.Name = "reload2";
            this.reload2.Size = new System.Drawing.Size(49, 23);
            this.reload2.TabIndex = 7;
            this.reload2.Text = "Reload";
            this.reload2.UseVisualStyleBackColor = true;
            this.reload2.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(865, 40);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(312, 20);
            this.txtUrl2.TabIndex = 8;
            this.txtUrl2.TextChanged += new System.EventHandler(this.txtUrl2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1183, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(810, 66);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(422, 246);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 660);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

