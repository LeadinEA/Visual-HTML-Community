using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_HTML.Script;

namespace Visual_HTML.Frame
{
    public partial class Newproject : Form
    {
        NewWebProject webProject = new NewWebProject();

        public Newproject()
        {
            InitializeComponent();
        }

        private void Newproject_Load(object sender, EventArgs e)
        {
            Bitmap bir = new Bitmap("Assets\\logo1.png");
            pictureBox1.Image = bir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == null || name.Text == "") return;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择一个项目路径";
            if(folder.ShowDialog() == DialogResult.OK)
            {
                poic.Text = folder.SelectedPath + "\\" + name.Text;
            }
        }

        private void cutin_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == null || listBox1.Text == "") MessageBox.Show("请选择一个项目模板","警告");
            if (listBox1.Text == "空项目") webProject.ctrlproject(0,poic.Text);
            if (listBox1.Text == "带有Hello World的项目") webProject.ctrlproject(1,poic.Text);
            if (listBox1.Text == "默认") webProject.ctrlproject(2, poic.Text);
            if (listBox1.Text == "带有标准文件头的项目") webProject.ctrlproject(3, poic.Text);
            webProject.ctrlprojectsln("你好世界\r\n我好世界",poic.Text +".kpg");
        }
    }
}
