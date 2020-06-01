using SolidDemo.OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OCP
{
    public class ElektrikliDepoServisi : IDepoServisi,IElektirkliDepoServisi
    {       
        public int PilKapasitesi {
            get
            {
                return 500 - PilKapasitesi;
            }           
        }

        public bool DepoBosMu(Araba araba)
        {
            return araba.ElektrikSeviye <= 0;
        }

        public int DepodakiBosYeriVer(Araba araba)
        {
            return 100 - araba.ElektrikSeviye;
        }

        public Araba SarjEt(Araba araba)
        {
            araba.ElektrikSeviye = 100;
            return araba;
        }

        public Araba SarjEt(Araba araba, int seviye)
        {
            araba.ElektrikSeviye = seviye;
            return araba;
        }
    }
}
