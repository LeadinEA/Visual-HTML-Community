using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_HTML.Script
{
    internal class openproject
    {
        NewWebProject nw = new NewWebProject();
        public string loadproject(string pich)
        {
            string a = nw.openproject(pich);
            return a;
        }
    }
}
