using SolidDemo.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.ISP
{
    public class Bird : IBird
    {
        public void Eat()
        {
            //yemek yedi
        }

        public void Spawn()
        {
            //yumurtladı
        }

        public void Walk()
        {
            //yürüdü
        }
    }
}
