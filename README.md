# 💠 MVC5 İle Admin Panelli Dinmaik Sözlük Projesi
Eğitmenliğini Murat Yücedağ'ın üstlendiği, Youtube'da bulunan "MVC Proje Kampı" oynatma listesinden yararlanarak tamamladığım bir web projesidir.

# 💠 Projenin Özellikleri
## ⭕ Kod tekrarını azaltmak için N-Katmanlı Mimari ve SOLID Prensiplerine başvurdum

## ⚪ Projem bu bağlamda 4 farklı katmandan oluşmaktadır. Bunlar;
### 🔸 Presentation Layer (Sunum Katmanı) :  Kullanıcıya sunulan arayüzü barındırır
### 🔸 Business Logic Layer (İş Mantığı Katmanı) : Uygulamanın kurallarını ve iş mantığını barındırır
### 🔸 Data Access Layer (Veri Erişim Katmanı) : Veri tabanı ile uygulama arasında bağlantı kurmayı sağlayan katmandır
### 🔸 Entity Layer (Varlık Katmanı) :  Codefirst yaklaşımını barındıran ve verilen saklandığı bir katmandır. 

## 🟣 Projem 4 farklı amaca uygun bölüme sahiplik yapmaktadır. Bunlar ise;
### 🔹 Admin Paneli : Adminler'in giriş yaptığı ve kategori,başlık,yazı,yazar,mesaj ve yetkilendirme alanlarında CRUD İşlemlerini yaptığı bölümdür.
### 🔹 Yazar Paneli : Yazarlar tarafından görüntülenen bu sayfada; yeni başlık oluşturma,mevcut başlıklar altına yazı yazma,diğer yazarlar arasında mesajlaşma ve mevcuttaki profilleri için düzenleme yapmasını sağlar.
### 🔹 Sözlük Paneli : Yetkilendirme ile birlikte login işlemi yapılmadan herkesin girip tüm başlıklar altındaki yazıları görüntüleyebildiği bölümdür.
### 🔹 Ana Sayfa - Vitrin Sayfası : Projede kullandığım yaklaşımlar,teknolojiler ve izlediğim yolların bulunduğu. Birnevi proje'nin özeti niteliğinde olan bölümdür.

## 🔵 Projede kullandığım teknolojiler
### ✶ C#
### ✶ Entity Framework CodeFirst Yapısı
### ✶ C# Asp.Net MVC
### ✶ Kurumsal Mimari
### ✶ SOLID Prensipleri
### ✶ SQL Veri Tabanı


# 🧑🏻‍💻 Admin Paneli

## 🔓 LogIn Paneli
### ➤  Admin olarak yetkilendirilmiş kişilerin giriş yapıp admin paneline ulaşmasını sağlayan sayfadır. Buradaki giriş bilgileri, veri tabanındaki bilgiler ile doğru orantılı olarak dinamik bir halde değişmektedir. Bu durumu elde etmek için ise Session yapısını kullandım. 
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/1dbb1602f0bb8c6e0c55a97a0b1c429195220e99/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20140641.png)

## 🏷️ Kategori Paneli
### ➤  Yetkilendirilip girişi başarı ile tamamlayan admin'in karşılaşacağı ilk panel olan kategori panelinde mevcut kategorileri görüntüleyip, ilgili butonlar aracılığı ile CRUD işlemlerini yapabilir. Başlıklar butonu ile, ilgili kategorideki başlıkları görüntüleyebilir. Silme butonu ile veriyi tamamen silmek yerine aktif-pasif durumları arasında geçiş yapabilir. Dilerse verileri de güncelleyebilir

![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/1dbb1602f0bb8c6e0c55a97a0b1c429195220e99/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20140710.png)

## ➕  Yeni Kategori Ekleme Paneli
### ➤  Admin, kategori adını ve ilgili açıklamayı yazarak yeni bir kategori girişi yapabilir
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/1dbb1602f0bb8c6e0c55a97a0b1c429195220e99/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141022.png)

## 📣  Başlıklar Paneli
### ➤  Admin, giriş yapılmış tüm bilgileri görüntüleyebilir. Sağ tarafta bulunan "Yazılar" butonu ile, ilgili başlığa ait yazıları görüntüleyebilir.  "Sil" butonu ile birlikte başlıkları aktif-pasif olarak değiştirebilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/1dbb1602f0bb8c6e0c55a97a0b1c429195220e99/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141036.png)

## 🔄 Başlık Güncelleme Paneli
### ➤ "Düzenle" butonu ile bir düzenleme sayfası açılır ve bu sayfaya Kayıtlı Veri'nin tüm bilgileri açılan sayfaya otomatik şekilde yüklenir. Admin burada, değişiklik yapılması gereken verileri günceller.
 ![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141105.png)  
## 𓂃🖊  Yazılar Paneli
### ➤  Admin, girilmiş olan tüm içerikleri buradan görüntüleyebilir
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141049.png)
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141056.png)

## ✍🏼 Yazarlar Bölümü
### ➤ Admin kayıtlı yazarları burada görüntüler, dilerse yazarların yazılarını görüntüleyebilir.

 ![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141115.png)  

## 🔄 Yazar Profil Düzenleme Paneli
### ➤ Yazara ait girilmiş bilgiler üzerinde gerekli değişiklikleri yapmak için bu paneli kullanır.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141127.png)


## ℹ️ Hakkımızda Paneli
### ➤ Admin Kayıtlı olan Hakkımızda yazılarını görüntüler, mevcut verileri güncelleyip silebilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/d3502d8fc485e1862d924a2adbf1b558e6887e33/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141138.png)

## ➕  Yeni Hakkımda Ekleme Paneli
### ➤ Dilerse yeni hakkımızda girişi yapabilir. Buradaki hakkımızda girişi için Pop-Up yapısını kullandım.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/dddc2a4d37c87d14190d623cc7b739c7d8135fb8/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141144.png)

## 📋  Raporlar Paneli
### ➤ Tamamlanan Projedeki verilerin raporlandığı paneldir
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141356.png)

## 📨 Mesajlar Paneli
### ➤ Adminler, gelen mesajlar bölümünden yazarlardan taraflarına iletilen mesajları görüntüleyebilir. Gönderilen mesajlarda ise adminler, yazarlara gönderdiği mesajları görebilir. Listelenen mesajlara tıklayarak içeriği görüntüleyebilir. 
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/dddc2a4d37c87d14190d623cc7b739c7d8135fb8/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141203.png)

## 🔑 Yetkilendirme Paneli
### ➤ Yetkilendirilmiş Adminler  burada görüntülenir, istenilirse "Yeni Admin Tanımla" butonu ile yetkilendirmeleri yapıp, mevcut yetkilendirme bilgilerini güncelleyebilir ve silme işlemi yapılabilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/dddc2a4d37c87d14190d623cc7b739c7d8135fb8/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141221.png)

## 🚫 Hata Sayfası Paneli
### ➤ Hata alınan sayfalar için hataları listeleyebiliriz.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/c9c0e2a27ab8180929e7f699e89fa2ee5214c7ff/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141349.png)

## 🎯Yetenek Kartım Paneli
### ➤ Burada, kendime ait bir yetenek kartım bulunmaktadır. Bilgi sahibi olduğum konular ve dereceleri burada listelenmektedir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/c9c0e2a27ab8180929e7f699e89fa2ee5214c7ff/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141338.png)

## 🌐 Siteye Git Paneli
### ➤ Bu bölümü kullanarak Anasayfaya ulaşabilirsiniz



# ✍🏼 Yazar Paneli

## 🔓 Yazar LogIn Paneli
### ➤ Yetkilendirilmiş yazarlar, doğru mail adresi ve şifre bilgileri ile giriş sağlayıp yazar paneline ulaşım sağlayabilir
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c4eecef50fc2d009100d400d156a80576a5e791/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143120.png)

## 🪪 Profilim Paneli
### ➤ Yazarların giriş yaptıktan sonra görüntülediği ilk sayfa olan Profilim sayfası burasıdır, buradaki kendilerine ait bilgileri güncelleyebilirler
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c4eecef50fc2d009100d400d156a80576a5e791/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20142008.png)

## 📣 Başlıklarım Paneli
### ➤ Yazar, "İçerikler" bölümü ile kendisinin açmış olduğu başlıkları görüntüler. İsterse "Yeni Başlık Ekle" bölümünden yeni başlık girişi yapabilir, "Düzenle" bölümünden mevcut başlık bilgilerini düzenler "Sil" bölümünden başlığı aktif-pasif hale getirebilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c4eecef50fc2d009100d400d156a80576a5e791/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20142026.png)
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143303.png)

## 📣 Tüm Başlıklar Paneli
### ➤ Yazar, girilmiş olan tüm başlıkları burada görüntüleyebilir. "Bu Başlığa Yaz" bölümü ile başlığa yorum yapabilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c4eecef50fc2d009100d400d156a80576a5e791/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143052.png)


## 📝 Yazılarım Paneli
### ➤ Yazar, kendisinin girmiş olduğu tüm yazıları burada görüntüler
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20142045.png)


## 📨 Mesajlar Paneli
### ➤ Adminler, gelen mesajlar bölümünden yazarlardan taraflarına iletilen mesajları görüntüleyebilir. Gönderilen mesajlarda ise adminler, yazarlara gönderdiği mesajları görebilir. Listelenen mesajlara tıklayarak içeriği görüntüleyebilir. 
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/dddc2a4d37c87d14190d623cc7b739c7d8135fb8/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141203.png)

## 🌐 Siteye Git Paneli
### ➤ Bu bölümü kullanarak Anasayfaya ulaşabilirsiniz

# 🌐 Anasayfa Paneli 

## 💻 Açılış Paneli


### ➤ Burada kendime ait bilgiler bulunmaktadır. 
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143619.png)


## 💻 Kullandığım Geliştirme Bileşenleri Paneli


### ➤ Üzerinde çalıştığım projede kullandığım teknolojiler burada yer almaktadır. 
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143632.png)

## 💻 Projede Neler Yaptım Paneli


### ➤ Projeyi geliştirirken üstünden geçtiğim işlemleri burada açıklamaya çalıştım.

![ImageAlt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143638.png)


## 💻 Görseller Paneli


### ➤ Projeye ait görseller burada bulunur.

![ImageAlt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143652.png)

## 📊 İstatistik Ve Notlar Paneli
### ➤ Projeye ait istatistiksel veriler ve eklediğim bazı küçük notlar burada görüntülenir.
![ImageAlt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143704.png)

## 📩 İletişim Paneli
### ➤ Sayfayı görüntüleyen kullanıcıların Adminlere ulaşmasını sağlayan paneldir.
![ImageAlt](https://github.com/SemihSanli/MVC_SOZLUK/blob/0c6b0fdb16c1b324ab3e13648c7aab0a37752b41/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20143711.png)


#  💰 Bu Proje Bana Neler Kattı;
## ⭐SOLID Yapısnı öğrenmemi ve pekiştirmemi
## ⭐N katmanlı mimari ile nasıl proje geliştirilip, mimarinin nasıl kurulacığını öğrenmemi ve pekiştirmemi
## ⭐Pop-Up yapısını pekiştirmemi
## ⭐Validation kontrollerini pekiştirmemi
## ⭐Asp.Net MVC Yapısını pekiştirmemi
## ⭐Hata Sayfalarının eklenmesi ve  pekiştirmemi
## ⭐CodeFirst İle Migration yapısını Pekiştirmemi


