using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.DIP
{
    class Program
    {
        /*Dependency Inversion Principle -Bağımlılığı ters çevirme ilkesi
         * 
         * üst seviye işlemler(yüksek seviyeli sınıf) alt seviye işlemlere(düşük seviyeli sınıf) bağımlı olmamalı, tam tersi olmalı!
         * 
         * alt seviye işlem: loglama
         * üst seviye işlem: entity class'ının içinde yapılan işlemler
         * 
         * ör:mesela entity içinde loglama ile ilgili işlem yazılırsa bu prensibe aykırı olur, bunun yerine loglama işini interface yapıp bu interface üzerinden başka bir classta işleri yaptırmak daha doğru olur
         * 
         * 
         * Dependency Inversion prensibi içinde aslında dependency injection tasarım deseni kullanılır,dependency bağımlılık anlamına gelir, yani aslında bağımlı olduğu sınıfı dışarıdan enjekte ederek uygulamak demektir.
         * 
         * Dependency injection desenini ayağa kaldırmak için ioc(inversion of control) container'lardan faydalanırız.
         * amaç:uygulama içinde kullanılan objelerin instance'larının yönetimi,bağımlılığı en aza indirmek
         * IOC için kullanılabilecek çeşitli kütüphaneler var,en popüler olanlar;
         * Ninject
         * Castle windsor
         * StructureMap
         * Autofac
         * Unity 
         */
        static void Main(string[] args)
        {
        }
    }
}
