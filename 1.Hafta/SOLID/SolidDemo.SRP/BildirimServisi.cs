using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SRP
{
    public class BildirimServisi
    {
        public static void YakitBildirim(int seviye)
        {
            Console.WriteLine("yeni seviye: "+seviye);
        }


        public static void MotorBildirim(bool motorCalisiyorMu)
        {
            Console.WriteLine("Motor "+(motorCalisiyorMu ?"çalıştırıldı":"durduruldu"));
        }

        public static void ArabaninDurumunuVer(Araba araba)
        {
            Console.WriteLine(araba.ToString());
        }
    }
}
