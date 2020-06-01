using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.LSP.Interface
{
    interface ISendSMS
    {
        string SendSMS(string message);
    }
}
