using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_HTML.Frame
{
    public partial class plugframe : Form
    {
        DirectoryInfo di = new DirectoryInfo("Plugins/");
        public plugframe()
        {
            InitializeComponent();
        }

        private void plugframe_Load(object sender, EventArgs e)
        {
            Icon icon = new Icon("Assets/vishtml.ico");
            this.Icon = icon;
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ScriptEngine se = Python.CreateEngine();
                dynamic obj = se.ExecuteFile("Plugins/" + listBox1.Text);
                if (checkBox1.Checked) obj.Pluginsmain(textBox1.Text);
                else obj.Pluginsmain();
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked) MessageBox.Show(obj.Pluginsmain(textBox1.Text), "插件");
                }
                else
                {
                    if (checkBox2.Checked) MessageBox.Show(obj.Pluginsmain(), "插件");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox1.Enabled = true;
            else textBox1.Enabled = false;
        }
    }
}
