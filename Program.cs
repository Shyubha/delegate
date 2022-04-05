using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_BaseDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();

            MyDelegate mydel = new MyDelegate(c.Addition);
            int result = mydel.Invoke(23, 11);
            Console.WriteLine(result);



            Test t = new Test();
            MyStrDel del = new MyStrDel(t.AcceptName);
            Console.WriteLine(t.AcceptName("test"));

            Console.WriteLine("================= Multicast Delegate Invokation List =================");

            MyDelegate mydel2 = new MyDelegate(c.Addition);
            mydel2 += new MyDelegate(c.Subtractio);
            mydel2 += new MyDelegate(c.Multiplay);


            Delegate[] list = mydel2.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(11, 14));
            }

            Console.WriteLine("========Remove From list==========");
            MyDelegate mydel3 = new MyDelegate(c.Addition);
            mydel3 -= new MyDelegate(c.Subtractio);
            mydel3 += new MyDelegate(c.Multiplay);
            Delegate[] list3 = mydel3.GetInvocationList();
            foreach (Delegate item in list3)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(11, 14));
            }


            Test t1 = new Test();

            MyStrDel delstr = new MyStrDel(t1.AcceptName);

            delstr += new MyStrDel(t.AcceptNameL);


            //Delegate[] list2 =new delstr.GetInvocationList();
            //foreach (Delegate i in list2)
            //{
            //    Console.WriteLine(i.Method);
            //    Console.WriteLine(i.DynamicInvoke("test"));
            //    Console.WriteLine(i.DynamicInvoke("TEST"));
            //}

        }
    }
}