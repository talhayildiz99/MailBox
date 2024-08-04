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
- **.NET Core 6.0**
- **Entity Framework (ORM) 6.0**
- **Code First**
- **Microsoft SQL Server (MSSQL) Veritabanı**
- **N-Architecture ve Repository tasarım deseni**
- **AutoMapper**
- **Fluent Validation**
- **Identity**
- **HTML/CSS/Bootstrap**
- **JavaScript**
- **Ajax**
- **LINQ**

#### Proje Görselleri

## Veritabanı

![Screenshot_22](https://github.com/user-attachments/assets/366d63f8-550a-4df8-bc31-f404fc804f60)

******************************************

## Kullanıcı Kaydı 
Kullanıcının portala kaydolması için ilgili bilgileri uygun formatta doldurması gerekir.

![Screenshot_2](https://github.com/user-attachments/assets/e8af389e-77cb-440f-98f2-5baf4ac75636)

******************************************

## Mail Onayı 
Girilen mail adresine bir onay kodu gönderilir ve bu kod girilene kadar kulllanıcı portala login olamaz.

![Screenshot_3](https://github.com/user-attachments/assets/9c0a740a-c07c-4c7e-ba73-4d85a6aa7fb9)

![Screenshot_4](https://github.com/user-attachments/assets/4040f81f-46aa-4f21-bf4e-d62fd0fbdf18)

******************************************

## Giriş
Kayıt ve mail onayı tamamlandıktan sonra kullanıcı bilgileriyle portala girilir.

![Screenshot_5](https://github.com/user-attachments/assets/1d75503c-f1dd-41e4-a0cb-554d2f3ed774)

******************************************

## Mail Gönderme 
"Yeni Mail Oluştur" butonuna basarak ilgili sayfaya yönderilir ve maili gönderebilirisiniz.

![Screenshot_6](https://github.com/user-attachments/assets/50a74987-2e08-4780-8a5d-eb3411327b9d)

Gönderme işlemi tamamlanan mailler "Gönderilen Mailler başlığı altında listelenir.

![Screenshot_7](https://github.com/user-attachments/assets/349da473-0476-4284-b6d4-b1f42fe4ddcc)

******************************************

## Taslaklar
Mail oluşturulurken "Taslak Olarak Kaydet" butonu ile mailler taslak mail olarak kaydedilir ve "Taslaklar" başlığı altında listelenir.

![Screenshot_9](https://github.com/user-attachments/assets/d65624cc-372a-481b-b69f-962ad38c00ab)

![Screenshot_10](https://github.com/user-attachments/assets/74e33a33-f61f-4cf5-b389-83a5822ff70a)

******************************************

## Gelen Kutusu 
Gelen Kutusu'nda size gönderilmiş olan mailler tarihe göre listelenir

![Screenshot_11](https://github.com/user-attachments/assets/b0410a23-c022-438b-9f2c-8d1b5b9f54e6)

******************************************

## Mail Okuma
Eğer mail okunmamışsa Gelen Kutusu'nda ilgili mailin sol tarafında sarı bir kenar çubuğu bulunur ve okunmamış mail olduğunu ifade eder.

![Screenshot_11](https://github.com/user-attachments/assets/9b04ac14-9581-4112-b4cc-9ee72c022398)

"Oku" butonuna basıldığında mailin detayları gelir.

![Screenshot_12](https://github.com/user-attachments/assets/7cf9f1f1-f30e-4645-9515-73260a5d5f73)

![Screenshot_14](https://github.com/user-attachments/assets/5659af4b-8aeb-427e-aa5a-1e81cd4b9466)

Tekrar genel kutusuna dönüldüğünde o mailin okunmamış olduğunu belirten sarı kenar çubuğu kalkacaktır.

![Screenshot_13](https://github.com/user-attachments/assets/7c08b119-b359-4317-8b2d-95fd339cff0d)

![Screenshot_15](https://github.com/user-attachments/assets/22cbb23a-fd61-4ffa-bb6e-ab3797c3a827)

******************************************

## Yıldızlı Mailler
Maillerin solunda bulunan "Yıldız" sembolüne basılarak mailler yıldızlanır ve yıldızlanan mesajların "Yıldız" sembolü sarıya döner.

![Screenshot_16](https://github.com/user-attachments/assets/676871d5-80ec-48cb-b661-29df8bbb6d23)

Aynı zamanda SideBar'da yer alan "Diğer" kısmında "Yıldızlı Mesajlar" başlığı altında listelenir.

![Screenshot_17](https://github.com/user-attachments/assets/bdf58d51-64ee-497e-bccb-225c91262dd1)

## Çöp Kutusu
Maillerin sağ tarafında bulunan "Sil" butonuna basılarak mailler "Çöp Kutusu"na taşınır. Silinen mailler "Kalıcı Olarak Sil" butonu ile veritabanından tamamen silinir.

![Screenshot_18](https://github.com/user-attachments/assets/c204e900-4a52-4a91-9638-aba0c8bb06a2)

******************************************

## Profil Bilgilerini Görüntüleme ve Güncelleme
"Profil" başlığı altında kullanıcıya ait bilgiler görüntülenebilir ve güncellebilir.

![Screenshot_19](https://github.com/user-attachments/assets/8710bb8d-56c7-4ae4-816e-ae5f175107a0)

******************************************

## İstatistikler
"Anasayfa" başlığı altında kullacıya ait istatistikler görüntülenir.

![Screenshot_20](https://github.com/user-attachments/assets/0d0ce484-ca25-40d3-a181-61c10f634a35)

******************************************

# Ayarlar ve Çıkış
NavBar'ın sağ üstünde yer alan kullanıcı adına tıklandığında "Ayarlar" başlığında "Profil"e yönlendirilir.
NavBar'ın sağ üstünde yer alan kullanıcı adına tıklandığında "Çıkış Yap" başlığında veya SideBar'da yer alan "Çıkış Yap" başlıklarına basıldığında LogOut olarak "Login" sayfasına yönlendirilir.

![Screenshot_21](https://github.com/user-attachments/assets/77815f17-0d09-40d7-8058-4bb470d7dd33)

******************************************

