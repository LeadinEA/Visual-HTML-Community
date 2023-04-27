using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Visual_HTML.Script
{
    internal class Save
    {
        private string pich;

        public void Saves(TextBox ric)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "另存项目文件";
            saveFile.Filter = "文本文件|*.txt|Javascript|*.js|Html文件|*.html|网页布局|*.css";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FilterIndex == 1) File.WriteAllText(saveFile.FileName, ric.Text);
                if (saveFile.FilterIndex == 2) File.WriteAllText(saveFile.FileName, ric.Text);
                if (saveFile.FilterIndex == 3) File.WriteAllText(saveFile.FileName, ric.Text);
                if (saveFile.FilterIndex == 4) File.WriteAllText(saveFile.FileName, ric.Text);
                pich = saveFile.FileName;
                MessageBox.Show("保存成功", "提示");
            }
        }

        public void Savestart(TextBox ric,ComboBox box)
        {
            if(pich == null)
            {
                if (box.Text == "") MessageBox.Show("请先选择一个代码模式", "警告");
                MessageBox.Show("请先保存文件","提示");
            }
            else
            {
                File.WriteAllText(pich, ric.Text);
                Process.Start(pich);
            }
        }
    }
}
