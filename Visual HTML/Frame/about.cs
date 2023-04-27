using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_HTML.Frame
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            Bitmap logo = new Bitmap("Assets/logo1.png");
            pictureBox1.Image = logo;
            linkLabel1.Links.Add(0,0,"https://kpgeystudio.site/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpgeystudio.site/");
        }
    }
}
