using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OCP.Interface
{
    public interface IElektirkliDepoServisi
    {
        int PilKapasitesi { get;}
        Araba SarjEt(Araba araba);
        Araba SarjEt(Araba araba,int seviye);
                     
    }
}
