using SolidDemo.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.ISP
{
    public class Seagull : Bird, IFlyable,ISwim
    {
        public void Fly()
        {
            //uçtu
        }

        public void Swim()
        {
            //yüzdü
        }

        public void BagelEating()
        {
            //simit yedi
        }
    }
}
