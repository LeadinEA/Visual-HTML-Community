using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_HTML.Frame;

namespace Visual_HTML.Script
{
    internal class NewWebProject
    {
        public NewWebProject()
        {

        }

        public void ctrlproject(int mode,string pich)
        {
            switch (mode)
            {
                case 0:
                    Directory.CreateDirectory(pich);
                    File.Copy("template\\Note.html",pich + "\\index.html");
                    break;
                case 1:
                    Directory.CreateDirectory(pich);
                    File.Copy("template\\Hello.html", pich + "\\index.html");
                    File.Copy("template\\hello.js", pich + "\\index.js");
                    break;
                case 2:
                    Directory.CreateDirectory(pich);
                    File.Copy("template\\index.html", pich + "\\index.html");
                    break;
                case 3:
                    Directory.CreateDirectory(pich);
                    File.Copy("template\\index.html", pich + "\\index.html");
                    break;
            }
        }

        public void ctrlprojectsln(string projectname, string pich)
        {
            FileStream fs = new FileStream(pich, FileMode.Create);
            autoben ab = new autoben()
            {
                projectnamen = projectname,
                projcr = pich
            };
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ab);
            fs.Close();
        }

        public string openproject(string pich)
        {
            string a = openprojectsln(pich);
            return a;
        }

        private string openprojectsln(string pich)
        {
            FileStream fs = new FileStream(pich,FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            autoben ab = bf.Deserialize(fs) as autoben;
            fs.Close();
            return ab.projcr +"\r\n"+ ab.projectnamen;
        }
    }

    [Serializable]
    public class autoben
    {
        public string projectnamen { get; set; }
        public string projcr { get; set; }
    }
}
