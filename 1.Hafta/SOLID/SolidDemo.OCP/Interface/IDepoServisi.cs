using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OCP.Interface
{
    public interface IDepoServisi
    {
        bool DepoBosMu(Araba araba);
        //bool DepoDoluMu(Araba araba);
        int DepodakiBosYeriVer(Araba araba);
    }
}
