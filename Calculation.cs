using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_BaseDemo
{
    public delegate int MyDelegate(int n1, int n2);

    public delegate string MyStrDel(string name);
    public class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtractio(int a, int b)
        {
            return a - b;
        }
        public int Multiplay(int x, int y)
        {
            return x * y;
        }

    }
    public class Test
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();
        }
        public string AcceptNameL(string nameL)
        {
            return nameL.ToLower();
        }
    }

}
