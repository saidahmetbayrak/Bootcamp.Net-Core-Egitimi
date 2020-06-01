using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SRP
{
    public class DepoServisi
    {
        public void ArabaninDeposunuFulle(Araba araba)
        {
            if (araba.BenzinSeviye < 100)
            {
                araba.BenzinSeviye = 100;
                //BildirimServisi.YakitBildirim(araba.BenzinSeviye);
            }
        }

        public void ArabayaKontrolluBenzinAl()
        {

        }


        //public bool DepoBosMu { get; set; }
        public bool DepoDoluMu(Araba araba) => araba.BenzinSeviye == 100;
        public int DepodakiBosYeriVer(Araba araba) => 100 - araba.BenzinSeviye;

        

    }
}
