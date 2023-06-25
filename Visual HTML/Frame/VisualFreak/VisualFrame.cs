using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_HTML.Frame.VisualFreak;

namespace Visual_HTML.Frame
{
    public partial class VisualFrame : Form
    {
        public VisualFrame()
        {
            InitializeComponent();
        }

        private void 属性窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attribute at = new attribute();
            at.Show();
        }

        private void 控件窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controls ct = new controls();
            ct.Show();
        }
    }
}
