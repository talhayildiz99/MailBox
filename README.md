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

![Mail Oluşturma](https://github.com/user-attachments/assets/baacb9cc-c199-48c7-b3d5-6f6bc7932004)

Gönderme işlemi tamamlanan mailler "Gönderilen Mailler başlığı altında listelenir.

![Screenshot_7](https://github.com/user-attachments/assets/b9a63705-a5d8-40d5-b304-395b62889421)

******************************************

## Taslaklar
Mail oluşturulurken "Taslak Olarak Kaydet" butonu ile mailler taslak mail olarak kaydedilir ve "Taslaklar" başlığı altında listelenir.

![Taslak Maili](https://github.com/user-attachments/assets/65c571ae-be0a-4c16-9ad1-5b7a7846d9ea)

![Taslaklar](https://github.com/user-attachments/assets/10c4d9e6-a30b-4e4d-80d7-a6b886f4bf00)

******************************************

## Gelen Kutusu 
Gelen Kutusu'nda size gönderilmiş olan mailler tarihe göre listelenir

![Screenshot_11](https://github.com/user-attachments/assets/b0410a23-c022-438b-9f2c-8d1b5b9f54e6)

******************************************

## Mail Okuma
Eğer mail okunmamışsa Gelen Kutusu'nda ilgili mailin sol tarafında sarı bir kenar çubuğu bulunur ve okunmamış mail olduğunu ifade eder.

![Screenshot_11](https://github.com/user-attachments/assets/9b04ac14-9581-4112-b4cc-9ee72c022398)

"Oku" butonuna basıldığında mailin detayları gelir.

![Oku](https://github.com/user-attachments/assets/4650c0b9-3d91-4968-aae1-b7726129368d)

![oku2](https://github.com/user-attachments/assets/713adb50-df28-409c-b9dc-f7f9bd235344)

Tekrar genel kutusuna dönüldüğünde o mailin okunmamış olduğunu belirten sarı kenar çubuğu kalkacaktır.

![Screenshot_13](https://github.com/user-attachments/assets/7c08b119-b359-4317-8b2d-95fd339cff0d)

![Screenshot_15](https://github.com/user-attachments/assets/22cbb23a-fd61-4ffa-bb6e-ab3797c3a827)

******************************************

## Yıldızlı Mailler
Maillerin solunda bulunan "Yıldız" sembolüne basılarak mailler yıldızlanır ve yıldızlanan mesajların "Yıldız" sembolü sarıya döner.

![Gelen Kutusu](https://github.com/user-attachments/assets/04a88c8d-37dd-4cf3-95d8-0f6e8c654a0f)

Aynı zamanda SideBar'da yer alan "Diğer" kısmında "Yıldızlı Mesajlar" başlığı altında listelenir.

![Yıldızlı Mesajlar](https://github.com/user-attachments/assets/f5753c4d-ec55-4378-9b26-fc1f14f967cf)

## Çöp Kutusu
Maillerin sağ tarafında bulunan "Sil" butonuna basılarak mailler "Çöp Kutusu"na taşınır. Silinen mailler "Kalıcı Olarak Sil" butonu ile veritabanından tamamen silinir.

![Çöp](https://github.com/user-attachments/assets/5b4e31f2-9072-4f0a-8931-76ce6c463bdf)

******************************************

## Profil Bilgilerini Görüntüleme ve Güncelleme
"Profil" başlığı altında kullanıcıya ait bilgiler görüntülenebilir ve güncellebilir.

![Profil](https://github.com/user-attachments/assets/9d45c816-3549-4916-a168-227e152e424d)

******************************************

## İstatistikler
"Anasayfa" başlığı altında kullacıya ait istatistikler görüntülenir.

![Dashboard](https://github.com/user-attachments/assets/08f5819b-43f6-4671-94cb-b48b5c181b18)

******************************************

# Ayarlar ve Çıkış
NavBar'ın sağ üstünde yer alan kullanıcı adına tıklandığında "Ayarlar" başlığında "Profil"e yönlendirilir.
NavBar'ın sağ üstünde yer alan kullanıcı adına tıklandığında "Çıkış Yap" başlığında veya SideBar'da yer alan "Çıkış Yap" başlıklarına basıldığında LogOut olarak "Login" sayfasına yönlendirilir.

![Screenshot_21](https://github.com/user-attachments/assets/77815f17-0d09-40d7-8058-4bb470d7dd33)

******************************************

