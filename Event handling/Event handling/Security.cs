using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_handling
{
    internal class Security
    {
        public void AllertPoilce(object? obj, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("police allerted .....");
        }


        public void EnageAntiVirus(Object obj, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Anti virus engine starts");
        }





    }
}
