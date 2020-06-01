using SolidDemo.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.LSP
{
    public class Iphone : CellPhone, ISendSMS,ISendMMS,IFingerRead
    {
        public Iphone()
        {
            Brand = "Apple";
            Model = "Iphone 11 Pro";
        }
        public string Read(string fingerPrint)
        {
            //parmak izi kodları sfdgs
            return fingerPrint;
        }

        public string SendMMS(string message)
        {
            //mms kodları sdgfdzfg
            return message;
        }

        public string SendSMS(string message)
        {
            //sms kodları afcsad
            return message;
        }
    }
}
