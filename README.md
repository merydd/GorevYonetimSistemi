# Görev Yönetim Sistemi

Bu proje C# ile kodlanmış bir konsol uygulamasıdır. Proje, yapılacak olan işlerin planlanmasının kolaylaşmasını sağlamak için yazılan bir kod bloğundan oluşmaktadır. Todolist’in amacı, yapılacakları bir düzen içerisinde kontrol etmektir. Proje, Nesne Yönelimli Programlama prensiplerini uygulayan bir konsol uygulamasıdır.

## Proje Genel Tanımı
Todolist ile yapılabilecek işlemleri anlatmak gerekirse; bir görev eklenirken bu görevin başlangıç ve bitiş tarihini, öncelik derecesi seçilebiliyor. Bir görev silinirken önce ekli olan görevler listeleniyor ve silinmek istenen görev soruluyor. Klasörlerde, tarihe göre sınıflandırılabilecek iki klasör bulunuyor: Bir hafta içindekiler ve bir ay içindekiler. Farklı klasörler de eklenebilir ve istenen görevler istenen klasörlere eklenebilir. 
Çalışma şekli de şu şekilde; program çalıştırıldığında bir giriş ekranı açılıyor. Kodun içinde ‘private’ olarak yazılmış olan kullanıcı bilgileri ile giriş yapıldığında, programda çalıştırılabilecek işlemler listeleniyor. 
Bu işlemler: görev ekle, görev çıkar, görevleri listele, tamamlanmış işaretle, klasör oluştur, klasörleri görüntüle.

## Gereksinimler

- Projenin farklı bir bilgisayarda çalıştırılabilmesi için Git sisteminin kurulu olması gereklidir.
- Projenin çalışabilmesi için Microsoft Visual Studio programı indirilmiş olmalıdır.

## Proje Detayları

1. *Encapsulation (Kapsülleme):* Programa giriş kısmında kullanıcı adı ve şifre 'private' olarak tanımlanmış ve get set metotlarıyla dışarıdan erişimi sağlanmıştır. Kullanıcı adı ve şifre, Authentication class'ı içerisinde tutulmaktadır.

2. *Class ve Nesnelerin kullanılması*

## Projenin Mimari Diyagramı
![algoritmasema](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/ae7e4da1-e8a0-401a-9702-9eb2cb5747bf)

## Projenin Ekran Görüntüleri
.Giriş Ekranı
 
![todogiris](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/f5a6be6d-b18e-419f-aa48-efe6f562bd72)

.Ana sayfa görüntüsü

![todoarayuz](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/70b3e42a-e7a9-45f0-98ee-093df20cd0a6)


