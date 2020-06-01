using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OCP.Interface
{
    public interface IYakitliDepoServisi
    {
        void ArabayaBenzinAl(Araba araba);
        void ArabayaBenzinAl(Araba araba, int benzinSeviyesi);

        //void TupDoldur(Araba araba);
        //tüplü arabanın extra özelliği olduğu için buraya yazmamak gerekir (SRP aykırı olur)

    }
}
