using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidDemo.LSP.Interface;

namespace SolidDemo.LSP
{
    public class Nokia3310 : CellPhone, ISendSMS
    {
        public string SendSMS(string message)
        {
            return message;
        }
    }
}
