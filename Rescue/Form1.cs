using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void url1Enter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(txtUrl2.Text);
        }

        private void txtUrl2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
