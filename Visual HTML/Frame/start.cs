using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_HTML.Frame;

namespace Visual_HTML
{
    public partial class start : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public start()
        {
            InitializeComponent();
        }

        private async void start_Load(object sender, EventArgs e)
        {
            MainFrame main = new MainFrame();
            Bitmap bitmap = new Bitmap("Assets/VisHTML.png");
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            pictureBox1.Image = bitmap;
            pictureBox1.Location = new Point(0,0);
            this.Opacity = 0;
            for(float i = 0;i <= 1; i+= 0.1f)
            {
                await Task.Delay(50);
                this.Opacity = i;
            }
            await Task.Delay(1000);
            if (main.init() == 0)
            {
                main.Show();
                this.Width = 0;
                this.Height = 0;
                this.TopMost = false;
                this.Opacity = 0;
            }
            else
            {
                MessageBox.Show("IDE初始化异常，请重新启动\r\n如果频繁出现此问题请反馈至KPGEY Studio官网", "警告");
                Process.GetCurrentProcess().Kill();
            }
        }

        private void down(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x00A1, 2, 0);
        }
    }
}
