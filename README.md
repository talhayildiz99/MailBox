# Mailbox Projesi
MY Academy kapsamında katılmış olduğum eğitimin üçüncü projesi olan Mailbox projesini hayata geçirdim.
Proje modern bir arayüz tasarımı ile kullanım kolaylığı sağlamaktadır.

#### Kullanıcı Arayüzünde;
Kullanıcılar e-posta gönderme, alma, taslak oluşturma, önemli e-postaları işaretleme, spam e-postaları filtreleme ve silinen e-postaları yönetme gibi işlemleri gerçekleştirebilir.
Şık ve kullanıcı dostu bir tasarım ile e-posta yönetimi sağlar.
- **Mail Oluştur:** Kullanıcılar yeni e-postalar oluşturabilir ve gönderebilir.
- **Gelen Kutusu:** Alınan e-postaları görüntüleme, okunmuş/okunmamış olarak işaretleme, yıldızlama ve silme seçenekleriyle.
- **Gönderilen Mailler:** Gönderilen e-postaları görüntüleme.
- **Taslaklar:** E-postaları taslak olarak kaydedip daha sonra düzenleyebilme.
- **Çöp Kutusu:** Silinen e-postaları görüntüleme ve kalıcı olarak silme.
- **Yıldızlı:** Önemli (yıldızlı) e-postaları görüntüleme.

#### Kullanılan Teknolojiler
- **.NET Core 6.0**: Web uygulamasının temel çerçevesi olarak kullanıldı. Yüksek performanslı ve platformlar arası geliştirme imkanı sağlar.
- **Entity Framework (ORM) 6.0**: Veritabanı etkileşimi ve ORM (Nesne İlişkilendirme Haritası) için kullanıldı. Veritabanı işlemlerini kodla yönetmeyi kolaylaştırır.
- **Microsoft SQL Server (MSSQL) Veritabanı**: Veritabanı yönetimi ve depolama için kullanıldı. Güvenilir ve ölçeklenebilir veri depolama çözümleri sunar.
- **N-Architecture ve Repository tasarım deseni**: Uygulamanın modüler ve sürdürülebilir olmasını sağlamak için kullanıldı. Katmanlı mimari ile kodun okunabilirliği ve yönetilebilirliği artırıldı.
- **AutoMapper**: Nesne eşlemesi (object-to-object mapping) işlemini kolaylaştırmak için kullanılan bir kütüphanedir. Veritabanı varlıklarını DTO'lara ve model nesnelere dönüştürmeyi kolaylaştırır.
- **Fluent Validation**: Girdi doğrulama işlemleri için kullanıldı. Model doğrulamalarını kolay ve okunabilir bir şekilde tanımlamayı sağlar.
- **Identity**: ASP.NET Core tabanlı web uygulamalarında kullanıcı kimlik doğrulama ve yetkilendirme işlemlerini sağlar. Kullanıcı yönetimi ve güvenlik işlemlerini kapsar.
- **HTML/CSS/Bootstrap**: Kullanıcı arayüzü tasarımı için kullanıldı. Modern ve duyarlı web sayfaları oluşturmayı sağlar.
- **JavaScript**: E-posta filtreleme ve kullanıcı etkileşimlerini yönetmek için kullanıldı. Dinamik ve interaktif web sayfaları oluşturmayı sağlar.
- **Ajax**: Mesaj ve Taslak Oluşturma, mesajı Çöp Kutusuna, Spam Kutusuna taşıma ve silme işlemlerinde kullanıldı. Sayfa yenilemeden veri alışverişini sağlar.
- **LINQ**: Veri sorgulama ve işleme için kullanıldı. C# dilinde veritabanı sorguları yazmayı kolaylaştırır.
- **Code First**: Veritabanı şeması, uygulama kodundan otomatik olarak oluşturuldu. Bu, veritabanı şemasını kodla tanımlama ve yönetme imkanı sağlar.
