using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Refactored
{
    class Araba
    {
        public Araba(string renk)
        {
            Renk = renk;
        }

        public Araba(string renk, int benzinSeviyesi)
        {
            Renk = renk;
            BenzinSeviyesi = benzinSeviyesi;
        }
        public int BenzinSeviyesi { get; set; }
        public bool MotorCalisiyorMu { get; set; }
        public string Renk { get; set; }

        //public void ArabayaBenzinAl()
        //{
        //    if (BenzinSeviyesi < 100)
        //    {
        //        BenzinSeviyesi = 100;
        //        Console.WriteLine("Depo fullendi");
        //    }
        //}

        public void ArabayaBenzinAl(int benzinSeviyesi)
        {
            if (BenzinSeviyesi < 100 && benzinSeviyesi <= 100 - BenzinSeviyesi)
            {
                BenzinSeviyesi += benzinSeviyesi;
                Console.WriteLine("arabaya benzin alındı");
            }
        }

        public void ArabayaBenzinAl()
        {
            if (BenzinSeviyesi < 100)
            {
                int fark = 100 - BenzinSeviyesi;
                BenzinSeviyesi += fark;
                Console.WriteLine("depo fullendi");
            }
        }

        public void MotoruCalistir()
        {
            if (BenzinSeviyesi <= 0)
            {
                ArabayaBenzinAl();
            }
            if (MotorCalisiyorMu)
            {
                throw new MotorZatenCalisiyorException("Motor zaten çalışıyor");
            }
            MotorCalisiyorMu = true;
            Console.WriteLine("motor çalıştı");
        }

        public void MotoruDurdur()
        {
            if (!MotorCalisiyorMu)
            {
                throw new MotorZatenCalismiyorException("motor zaten çalışmıyor");
            }
            MotorCalisiyorMu = false;
            Console.WriteLine("motor durduruldu");
        }
    }

    public class MotorZatenCalisiyorException : Exception
    {
        // public override string Message => base.Message;
        public MotorZatenCalisiyorException(string aciklama) : base(aciklama)
        {
        }
    }
    public class MotorZatenCalismiyorException : Exception
    {
        public MotorZatenCalismiyorException(string aciklama) : base(aciklama)
        {
        }
    }
}
