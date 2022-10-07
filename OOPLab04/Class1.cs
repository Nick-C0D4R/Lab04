using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab04
{
    public class Class1
    {
        public virtual void Method1(params object[] items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
