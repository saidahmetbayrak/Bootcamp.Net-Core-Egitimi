using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.DIP
{
    public class UzakKontrol:IUzakKontrol
    {
        //IUzakKontrol _kontrol;
        //public UzakKontrol(IUzakKontrol kontrol)
        //{
        //    _kontrol = kontrol;
        //}
        //public void SesAc()
        //{
        //    _kontrol.Ac();
        //}

        //public void SesKapat()
        //{
        //    _kontrol.Kapa();
        //}

        public void Ac()
        {
            throw new NotImplementedException();
        }

        public void Kapa()
        {
            throw new NotImplementedException();
        }

        //public IUzakKontrol KontrolDegistir
        //{
        //    get
        //    {
        //        return _kontrol;
        //    }
        //    set
        //    {
        //        _kontrol = value;
        //    }
        //}
    }
}
