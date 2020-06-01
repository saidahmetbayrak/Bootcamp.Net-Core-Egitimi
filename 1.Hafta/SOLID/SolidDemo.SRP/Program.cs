using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SRP
{
    class Program
    {
        /*Single Responsibility principle-Tek sorumluluk ilkesi
         (isviçre çakısı olma-Kullanma!!)
         *her iş ya da sorumluluk tek bir şeye ait olmalı
         * 
         * örneğin bir class var ve üzerinde değişiklik yapıldığında hem DAL hem UI katmanı etkileniyorsa burada bu prensibe uyulmamış demektir!
         * eğer bir iş birden fazla işe bölünebiliyorsa bölünmelidir, bu bize modülerliği sağlar. 
             
             */
        static void Main(string[] args)
        {
            Araba araba = new Araba("kırmızı", 50);
            MotorServisi mt = new MotorServisi(araba);
            //mt.MotoruCalistir();
            BildirimServisi.ArabaninDurumunuVer(araba);

            Console.ReadLine();
            
        }
    }
}
