using SolidDemo.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.ISP
{
    public class Parrot : Bird, IFlyable, ITalk
    {
        public void Fly()
        {
            //uçtu
        }

        public void Talk()
        {
           //slm nbr dedi
        }
    }
}
