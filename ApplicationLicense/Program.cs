using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ApplicationLicense license = new ApplicationLicense("ProKey");
            PrintLicense(license);
        }

        private static void PrintLicense(ApplicationLicense license)
        {
            try
            {
                license.AllowPro();
                license.AllowTrial();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                license.AllowCommon();
            }
        }
    }
}
