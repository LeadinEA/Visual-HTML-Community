using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_HTML.Script
{
    internal class Kspparse
    {
        public string KSPparse(string Path,int liner)
        {
            string[] str = File.ReadAllLines(Path);
            string[] ary = str[liner].Split('=');
            return ary[1];
        }
        public void KSPstorage(string Path,string text,string classname,int mode)
        {
            if (mode == 0) File.WriteAllText(Path, $"{classname}=" + text);
            else if (mode == 1) File.AppendAllText(Path, $"{classname}=" + text);
        }
    }
}
