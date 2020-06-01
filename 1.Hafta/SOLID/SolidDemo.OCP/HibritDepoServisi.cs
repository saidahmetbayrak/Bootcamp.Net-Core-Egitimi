using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidDemo.OCP.Interface;

namespace SolidDemo.OCP
{
    public class HibritDepoServisi : IElektirkliDepoServisi,IYakitliDepoServisi,IDepoServisi
    {
        public int PilKapasitesi => throw new NotImplementedException();

        public void ArabayaBenzinAl(Araba araba)
        {
            throw new NotImplementedException();
        }

        public void ArabayaBenzinAl(Araba araba, int benzinSeviyesi)
        {
            throw new NotImplementedException();
        }

        public bool DepoBosMu(Araba araba)
        {
            return araba.BenzinSeviye == 0 && araba.ElektrikSeviye <= 0;
        }

        public int DepodakiBosYeriVer(Araba araba)
        {
            throw new NotImplementedException();
        }

        public Araba SarjEt(Araba araba)
        {
            throw new NotImplementedException();
        }

        public Araba SarjEt(Araba araba, int seviye)
        {
            throw new NotImplementedException();
        }
    }
}
