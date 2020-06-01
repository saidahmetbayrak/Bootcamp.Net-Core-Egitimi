using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SolidDemo.SRP.Helper.CustomException;

namespace SolidDemo.SRP
{
    public class MotorServisi
    {
        private DepoServisi _depoServisi;
        public MotorServisi(Araba araba)
        {
            _depoServisi = new DepoServisi();
        }

        public MotorServisi(DepoServisi depoServisi)
        {
            _depoServisi = depoServisi;
        }

        public bool MotorCalisiyorMu { get; set; }

        public void MotoruCalistir(Araba araba)
        {
            if (_depoServisi.DepoDoluMu(araba))
            {
                Console.WriteLine("motor çalıştı");
            }
            araba.MotorCalisiyorMu = true;
        }

        public void MotoruDurdur(Araba araba)
        {
            if (!MotorCalisiyorMu)
            {
                throw new MotorZatenCalismiyorException("drgdr");
                //throw new Exception("motor zaten çalışmıyor");
            }
            araba.MotorCalisiyorMu = false;
        }

    }
}
