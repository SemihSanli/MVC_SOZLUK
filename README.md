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
### ➤  Admin, giriş yapılmış tüm bilgileri görüntüleyebilir. Sağ tarafta bulunan "Yazılar" butonu ile, ilgili başlığa ait yazıları görüntüleyebilir. "Düzenle" butonu ile bir düzenleme sayfası açılır ve bu sayfaya Kayıtlı Veri'nin tüm bilgileri açılan sayfaya otomatik şekilde yüklenir. Admin burada, değişiklik yapılması gereken verileri günceller. "Sil" butonu ile birlikte başlıkları aktif-pasif olarak değiştirebilir.
![Image Alt](https://github.com/SemihSanli/MVC_SOZLUK/blob/1dbb1602f0bb8c6e0c55a97a0b1c429195220e99/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-05%20141036.png)

