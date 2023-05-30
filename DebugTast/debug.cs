using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugTast
{
    public partial class debug : Form
    {

        private int mousex;
        private int mousey;

        public debug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void debug_Load(object sender, EventArgs e)
        {
            Icon icon = new Icon("Assets/vishtml.ico");
            this.Icon = icon;
            Ghos.BackColor = Color.GhostWhite;
            this.TransparencyKey = Color.GhostWhite;
        }

        private void mouseupdate_Tick(object sender, EventArgs e)
        {
            Point ms = this.PointToClient(Control.MousePosition);
            mousex = ms.X;
            mousey = ms.Y;
            label1.Text = "X:" + mousex + "Y:" + mousey;
            if (checkBox1.Checked)
            {
                Ghos.Left = mousex;
                Ghos.Top = mousey;
            }
        }

        private void Down(object sender, MouseEventArgs e)
        {
            //Ghos.Left = mousex;
            //Ghos.Top = mousey;
        }

        private void fromdown(object sender, MouseEventArgs e)
        {
            Ghos.Left = mousex;
            Ghos.Top = mousey;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "隐藏光标")
            {
                Cursor.Hide();
                button3.Text = "显示光标";
                return;
            }
            else
            {
                Cursor.Show();
                button3.Text = "隐藏光标";
                return;
            }

        }




        private void button4_Click(object sender, EventArgs e)
        {
            Ghos.Width = int.Parse(textBox1.Text);
            Ghos.Height = int.Parse(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updatecolor_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.BackColor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            }
            if (checkBox3.Checked)
            {
                Random random = new Random();
                trackBar1.Value = random.Next(0, 255);
                trackBar2.Value = random.Next(0, 255);
                trackBar3.Value = random.Next(0, 255);
            }
        }
    }

    [Serializable]
    public class tastvalue
    {
        public string tast { get; set; }
    }
}
