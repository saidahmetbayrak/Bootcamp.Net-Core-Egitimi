using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OCP
{
    public class Araba
    {
        public Araba(string renk)
        {
            Renk = renk;
        }
        public int BenzinSeviye { get; set; }
        public int ElektrikSeviye { get; set; }
        public bool MotorCalisiyorMu { get; set; }
        public string Renk { get; set; }
        public YakitTipi YakitTipi { get; set; }

        public override string ToString()
        {
            return Renk + " renkli arabanın motoru " + (MotorCalisiyorMu ? "çalışıyor" : "çalışmıyor") + " benzin seviyesi " + BenzinSeviye + " elektrik seviyesi " + ElektrikSeviye + " dir";
        }
    }

    public enum YakitTipi
    {
        benzin,
        BenzinTup,
        diesel,
        elektrik
    }
}
