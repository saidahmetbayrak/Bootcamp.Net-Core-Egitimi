# Bootcamp.Net-Core-Egitimi
- - -
# 1.Hafta(30-05-2020/31-05-2020)

## The SOLID Principle
- - - 
![The Solid](https://miro.medium.com/max/1134/0*1mzotR23unNhunBc.png)

* Single Responsibility Principle - Tek sorumluluk ilkesi
* Open/Closed Principle - Açıp Kapama ilkesi
* Liskov ‘s Substitution Principle - Liskov'un yer değiştirme ilkesi
* Interface Segregation Principle - Arayüz ayırma ilkesi 
* Dependency Inversion Principle - Bağımlılığı ters çevirme ilkesi

> OOP'un ucunu kaçırmamak için SOLID prensipleri uygulanır. Yazılımda sürdürülebilirlik, temiz kod, kendini tekrar etme, ihtiyacın olmayan şeyi yapma, yazılan kodlar tekrar kullanılabilir olmalı, okunabilirliği yüksek, geliştirmeye açık

> Kalıplaşmamış ama yine de OOP prensibi olan; YAGNI,KISS,DRY
- - -
### Single Responsibility Principle

![Single Responsibility Principle](https://miro.medium.com/max/507/1*ZmlQz3oYedV3Go6uEOg3Tg.jpeg)

* Bir sınıf **nesne** yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın **fonksiyona da indirgenebilir** yapması gereken yalnızca bir işi olması gerekir.

### Open/Closed Principle

![Open/Closed Principle](https://miro.medium.com/max/418/1*4n5oJ7FAMVQ_75p8JDmsgg.jpeg)

* Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.

### Liskov ‘s Substitution Principle

![Liskov ‘s Substitution Principle](https://miro.medium.com/max/640/1*YoJQ6jhFFHTxUhGi7qnrrw.jpeg)

* Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.

### Interface Segregation Principle

![Interface Segregation Principle](https://miro.medium.com/max/640/1*4jaxF2SGryL7cRaIQB-Qkg.jpeg)

* Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.

### Dependency Inversion Principle

![Dependency Inversion Principle](https://miro.medium.com/max/624/1*2MpaejruP6j5iAuN90YHPQ.jpeg)

* Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

