using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.DIP
{
    public class TV : IUzakKontrol
    {
        public void Ac()
        {
            Console.WriteLine("televizyon uzaktan kumanda ile açıldı");
        }

        public void Kapa()
        {
            Console.WriteLine("televizyon uzaktan kumanda ile kapatıldı");
        }
    }
}
