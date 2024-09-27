TatildeKal

Bu proje, otel yönetim sistemine yönelik bir web uygulamasıdır. Kullanıcıların otel bilgilerini yönetmesi, rezervasyon yapması ve otel özelliklerine göz atması gibi işlemleri gerçekleştirmesini sağlayan bir platform sunar. Proje çeşitli katmanlardan oluşur ve her katman farklı sorumluluklara sahiptir.

Teknolojiler ve Kullanılan Diller:

* ASP.NET Core Web API: Web API hizmetlerini sunmak için kullanıldı.
* Entity Framework Core: Veritabanı işlemlerini yönetmek için kullanıldı.
* C#: Tüm backend ve iş katmanı kodları için kullanıldı.
* JWT (JSON Web Token): Kullanıcı doğrulama ve yetkilendirme işlemlerini gerçekleştirmek için kullanıldı.
* Rapid API: Dış servislerle entegrasyon için kullanıldı.
* HTML, CSS, JavaScript: Frontend katmanında kullanıcı arayüzünü oluşturmak için kullanıldı.

Proje Yapısı:

* ApiConsume: Otel API'lerinin tüketildiği katmandır. Diğer sistemlerle entegrasyon sağlar.
* HotelProject.WebApi: API uç noktalarını barındıran katmandır. Otel rezervasyon, kullanıcı yönetimi gibi işlemleri yöneten endpointler burada yer alır.
* HotelProject.EntityLayer: Veritabanı tablolarına karşılık gelen entity sınıflarının bulunduğu katmandır.
* HotelProject.DataAccessLayer: Veritabanı ile iletişimi sağlayan katmandır. Entity Framework Core kullanılarak veritabanı işlemleri gerçekleştirilir.
* HotelProject.BusinessLayer: İş kurallarının uygulandığı katmandır. Veritabanından gelen verilerin işlenmesi ve doğrulanması gibi işlemler bu katmanda gerçekleştirilir.
* HotelProject.DtoLayer: API ile client arasında veri transferi için kullanılan veri transfer objeleri (DTO'lar) burada tanımlanmıştır.
* HotelProject.WebUI: Kullanıcıların web arayüzü üzerinden uygulamaya eriştiği frontend katmanıdır.
* RapidApiConsume: Dış API'lerin kullanıldığı modül. Örneğin, otel bilgilerini üçüncü parti servislerden almak için kullanılır.
* WebApiJwt: JWT doğrulama ve yetkilendirme süreçlerini yöneten katmandır.

Kurulum:

* Projeyi klonlayın:
  https://github.com/gokselkaradag/TatildeKal.git

* Veritabanı bağlantı ayarlarını yapılandırın (appsettings.json).

* Aşağıdaki komut ile projeyi çalıştırın:
  dotnet run

* Frontend kısmını çalıştırmak için Frontend/HotelProject.WebUI dizinine gidin ve gerekli bağımlılıkları yükledikten sonra projeyi başlatın.

Özellikler:

* Kullanıcı Girişi ve Kayıt: JWT ile güvenli kimlik doğrulama.
* Otel Bilgileri Yönetimi: Otel bilgilerini ekleme, güncelleme ve silme.
* Rezervasyon Sistemi: Otel rezervasyonu yapma.
* API Tüketimi: Rapid API üzerinden üçüncü parti otel bilgilerini çekme.

Proje, modern web geliştirme yaklaşımlarını kullanarak ölçeklenebilir ve güvenli bir çözüm sunar.


Proje Görselleri

Proje hakkında daha fazla bilgi edinmek için aşağıdaki görsellere göz atabilirsiniz:

* Ana Sayfa

![Ekran görüntüsü 2024-09-27 154113](https://github.com/user-attachments/assets/bfd64199-394b-45fd-8f37-54f2c63b48f1)

![Ekran görüntüsü 2024-09-27 154127](https://github.com/user-attachments/assets/b513813c-bd7a-458d-8bb1-c51ee09ebb96)

![Ekran görüntüsü 2024-09-27 154141](https://github.com/user-attachments/assets/135e96e0-39a5-45b0-9eae-d815a11f411c)

![Ekran görüntüsü 2024-09-27 154201](https://github.com/user-attachments/assets/19f93137-db05-43fb-8140-486ff8a4975c)

![Ekran görüntüsü 2024-09-27 154227](https://github.com/user-attachments/assets/80af7a60-269c-467f-b445-08825ca7d58d)


* Kullanıcı Girişi

![image](https://github.com/user-attachments/assets/bcf33171-429d-4f71-b294-b5236c677fcc)

![image](https://github.com/user-attachments/assets/9a14a63f-31a6-415a-80e4-1d226f2e3f2c)















