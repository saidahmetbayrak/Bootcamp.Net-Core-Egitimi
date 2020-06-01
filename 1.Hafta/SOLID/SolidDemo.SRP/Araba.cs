using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SRP
{
    public class Araba
    {
        public Araba(string renk, int benzinSeviye)
        {
            Renk = renk;
            BenzinSeviye = benzinSeviye;
        }

        private int _benzinSeviye;
        public int BenzinSeviye
        {
            get
            {
                return _benzinSeviye;
            }
            set
            {
                _benzinSeviye = value;
                BildirimServisi.YakitBildirim(value);
            }
        }

        private bool _motorCalisiyorMu;
        public bool MotorCalisiyorMu
        {
            get
            {
                return _motorCalisiyorMu;
            }
            set
            {
                _motorCalisiyorMu = value;
                BildirimServisi.MotorBildirim(value);
            }
        }
        public string Renk { get; set; }

        public override string ToString()
        {
            return Renk + "renkli arabanın motoru " + (MotorCalisiyorMu ? "çalışıyor" : "çalışmıyor") + " benzin seviyesi " + BenzinSeviye + " litredir";
        }

    }

}
