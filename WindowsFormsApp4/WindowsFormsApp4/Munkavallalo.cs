using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Munkavallalo
    {
        public string vezetekNev;
        public string keresztNev;
        public DateTime szuletes;
        public string szakma;
        public Munkavallalo(string vezetekNev, string keresztNev, DateTime szuletes, string szakma)
        {
            this.vezetekNev = vezetekNev;
            this.keresztNev = keresztNev;
            this.szuletes   = szuletes;
            this.szakma = szakma;
        }
    }
}
