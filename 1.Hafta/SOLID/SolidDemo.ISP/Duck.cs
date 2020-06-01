using SolidDemo.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.ISP
{
    public class Duck : Bird, ISwim
    {
        public void Swim()
        {
            //yüzdü
        }
    }
}
