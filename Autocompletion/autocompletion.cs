using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Autocompletion
{
    public class autocompletion
    {
        public string[] source;

        public void init(int mode)
        {
            switch (mode)
            {
                case 0://标题
                    source = new string[]{
                            "<h1>",
                            "<h2>",
                            "<h3>",
                            "<h4>",
                            "<h5>",
                            "<h6>",
                            "p"
                        };
                    break;
                case 1://脚本
                    source = new string[]{
                            "<Script>",
                            "<h2>",
                            "<h3>",
                            "<h4>",
                            "<h5>",
                            "<h6>",
                        };
                    break;
                case 2://交互
                    source = new string[]{
                            "<nih>",
                            "<h2>",
                            "<h3>",
                            "<h4>",
                            "<h5>",
                            "<h6>",
                        };
                    break;
                case 3://控件
                    source = new string[]{
                            "<lasdas>",
                            "<h2>",
                            "<h3>",
                            "<h4>",
                            "<h5>",
                            "<h6>",
                        };
                    break;
                case 4://其他
                    source = new string[]{
                            "<askaleww>",
                            "<h2>",
                            "<h3>",
                            "<h4>",
                            "<h5>",
                            "<h6>",
                        };
                    break;
            }
        }

        public void autobu(System.Windows.Forms.ComboBox tex) {

            tex.AutoCompleteCustomSource.AddRange(source);
            tex.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tex.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void autobuText(System.Windows.Forms.TextBox tex)
        {
            tex.AutoCompleteCustomSource.AddRange(source);
            tex.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tex.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void autobuComDown(System.Windows.Forms.ComboBox tex)
        {
            tex.Items.Clear();
            tex.Items.AddRange(source);
        }
        public void autobusuoying(System.Windows.Forms.ComboBox tex)
        {

            string[] source = new string[] {
                "标题",
                "脚本",
                "交互",
                "控件",
                "其他"
            };


            tex.Items.AddRange(source);
        }
    }
}
