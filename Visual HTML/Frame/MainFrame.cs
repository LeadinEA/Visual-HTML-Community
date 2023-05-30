using Autocompletion;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Visual_HTML.Script;

namespace Visual_HTML.Frame
{
    public partial class MainFrame : Form
    {

        OpenDesk open = new OpenDesk();
        Save save = new Save();
        autocompletion autocompletion = new autocompletion();
        openproject openp = new openproject();

        public MainFrame()
        {
            //autocompletion.autobu(comboBox2);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            autocompletion.init(0);
            autocompletion.autobu(comboBox2);
            autocompletion.autobuComDown(comboBox2);
            autocompletion.autobusuoying(comboBox3);
            autocompletion.autobuText(textBox1);
        }

        public int init()
        {
            //if(InitializeComponent() == 0) return 0;
            //else return 1;
            InitializeComponent();
            return 0;
        }

        private void Quit(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting set = new setting();
            set.Show();
        }

        private void 新建Web项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newproject newproject = new Newproject();
            newproject.Show();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Saves(textBox1);
        }

        private void updatemenu_Tick(object sender, EventArgs e)
        {
            treeView1.Height = this.Height - 139;
            textBox1.Height = this.Height - 139;
            textBox1.Width = this.Width - 295;
            comboBox1.Location = new Point(this.Width - 110, 44);
            label1.Location = new Point(comboBox1.Location.X,29);
            tryfix.Left = this.Width - 103;
            starthtml.Left = this.Width - 188;
            comboBox3.Left = this.Width - 362;
            label2.Left = this.Width - 276;
            comboBox2.Left = this.Width - 489;
            if (comboBox1.Text == "Html") starthtml.Enabled = true;
            if (comboBox1.Text == "CSS") starthtml.Enabled = false;
            if (comboBox1.Text == "JavaScript") starthtml.Enabled = false;
            if (comboBox1.Text == "txt") starthtml.Enabled = true;
            //comboBox2.Text = textBox1.TextLength.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text ="<!DOCTYPE html>\r\n<html lang=\"cn\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Hello World</title>\r\n</head>\r\n" + a;
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开文件";
            openFileDialog.Filter = "文本文件|*.txt|Javascript|*.js|Html文件|*.html|网页布局|*.css";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strings = File.ReadAllText(openFileDialog.FileName);
                textBox1.Text = strings;
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "打开文件夹路径";
            if(folder.ShowDialog() == DialogResult.OK)
            {
                open.ShowTreeView(treeView1, folder.SelectedPath);
            }
        }

        private void 打开项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendl = new OpenFileDialog();
            opendl.Title = "打开Visual HTML项目文件";
            opendl.Filter = "Visual HTMl|*.kpg";
            if(opendl.ShowDialog() == DialogResult.OK)
            {
                if(opendl.FilterIndex == 1)
                {
                    string a = openp.loadproject(opendl.FileName);
                    textBox1.Text = a;
                }
            }
        }

        private void starthtml_Click(object sender, EventArgs e)
        {
            save.Savestart(textBox1,comboBox1);
        }

        private void TextDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                textBox1.Text += comboBox2.Text;
            }
            if(e.KeyCode == Keys.T)
            {
                textBox1.Text += "Aspe";
            }
            if (e.KeyCode == Keys.F1)
            {
                textBox1.Text += comboBox2.Text;
            }
        }

        private void FrameDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                textBox1.Text += "你好";
            }
        }

        private void dllupdate_Tick(object sender, EventArgs e)
        {
            if (comboBox3.Text == "标题") autocompletion.init(0);
            if (comboBox3.Text == "脚本") autocompletion.init(1);
            if (comboBox3.Text == "交互") autocompletion.init(2);
            if (comboBox3.Text == "控件") autocompletion.init(3);
            if (comboBox3.Text == "其他") autocompletion.init(4);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            autocompletion.autobuComDown(comboBox2);
        }

        private void 插件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plugframe pf = new plugframe();
            pf.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help\\help.chm");
        }

        private void rustHenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Tools\\RustHen.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
            
        }
    }
}
