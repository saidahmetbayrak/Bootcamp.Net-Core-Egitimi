using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("kırmızı");
            araba.MotorCalisiyorMu = true;
            araba.MotoruDurdur();
            araba.ArabayaBenzinAl();
        }
    }
}
