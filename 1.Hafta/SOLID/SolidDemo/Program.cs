using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo
{
    class Program
    {
        /*SOLID Principle
         * Single responsibility -Tek sorumluluk ilkesi
         * Open Close -Açıp kapama ilkesi
         * Liskov's Substitution -Liskov'un yer değiştirme ilkesi
         * Interface segregation -Arayüz ayırma ilkesi 
         * Dependency inversion -Bağımlılığı ters çevirme ilkesi
         * 
         * NOT:OOP'un ucunu kaçırmamak için SOLID prensipleri uygulanır.
         * 
         * Yazılımda sürdürülebilirlik, temiz kod, kendini tekrar etme, ihtiyacın olmayan şeyi yapma, yazılan kodlar tekrar kullanılabilir olmalı, okunabilirliği yüksek, geliştirmeye açık
         * 
         * Kalıplaşmamış ama yine de OOP prensibi olan; YAGNI,KISS,DRY
         */
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Renk = "Kırmızı";
            araba.BenzinSeviyesi = 100;
            araba.MotorCalisiyorMu = true;

            Console.WriteLine("kırmızı arabanın benzin seviyesi 100 ve motor çalışıyor..");

            Console.ReadLine();
        }

        public class Araba
        {
            public int BenzinSeviyesi { get; set; }
            public bool MotorCalisiyorMu { get; set; }
            public string Renk { get; set; }

        }

    }
}
