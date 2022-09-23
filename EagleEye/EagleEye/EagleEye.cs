using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye
{
    public partial class EagleEyeForm : Form
    {
        public string Url { get; set; }

        public EagleEyeForm()
        {
            InitializeComponent();
        }
        private void EagleEyeForm_Load(object sender, EventArgs e)
        {

        }

        private void spiderButton_Click(object sender, EventArgs e)
        {
            Spider spider = new Spider();
            spider.spiderUrl(Url);
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setUrlButton_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            String strUrl;
            bool bResult;

            strUrl = urlTextBox.Text.ToString();

            if (strUrl == "")
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            /* Checks if URL (HTTP/HTTPS) is valid. */


            bResult = Uri.TryCreate(strUrl, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (bResult == false)
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }

            else
            {
                Url = strUrl;
            }

        }

        private void spiderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
