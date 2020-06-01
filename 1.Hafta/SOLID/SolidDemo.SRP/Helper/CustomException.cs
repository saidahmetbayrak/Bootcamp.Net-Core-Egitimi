using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SRP.Helper
{
    public class CustomException
    {
        public class MotorZatenCalismiyorException:Exception
        {
            public MotorZatenCalismiyorException(string aciklama):base(aciklama)
            {

            }

        }
    }
}
