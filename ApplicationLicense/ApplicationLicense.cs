using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    public class ApplicationLicense
    {
        private readonly string proKey = "ProKey";
        private readonly string trialKey = "TrialKey";
        private readonly string key;

        public ApplicationLicense(string key) => this.key = key;

        private void ThrowELicenseError(string name) => throw new Exception($"Ви не можете використовувати дану версію.({name})");

        public void AllowTrial()
        {
            if (key == trialKey)
                Console.WriteLine("Тріальний режим");
            else ThrowELicenseError("Trial");
        }

        public void AllowPro()
        {
            if (key == proKey)
                Console.WriteLine("Платна версія");
            else ThrowELicenseError("Pro");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }

    }
}
