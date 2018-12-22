using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentChildForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            facbookForm fb = new facbookForm();
            fb.MdiParent = this;
            fb.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            twitterForm twit = new twitterForm();
            twit.MdiParent = this;
            twit.Show();
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            instagramForm insta = new instagramForm();
            insta.MdiParent = this;
            insta.Show();
        }
    }
}
