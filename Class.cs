using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Class
    {
        public string A;
        public double B;
        public string C;
        public Class(string a, double b, string c) { A = a; B = b; C = c; }
        public void Print(Class cl) { Console.WriteLine(cl.A + ", " + cl.B + ", " + cl.C); }
    }
}
