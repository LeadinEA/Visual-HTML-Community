using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugTast
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }

    [Serializable]
    public class tastvalue
    {
        public string tast { get; set; }
    }
}
