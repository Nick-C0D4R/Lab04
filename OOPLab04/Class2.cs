using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab04
{
    public class Class2 : Class1
    {
        public override void Method1(params object[] items)
        {
            Random random = new Random();
            foreach (var item in items)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine($"{item.GetType()} {item.ToString()}");
                
            }
        }
    }
}
