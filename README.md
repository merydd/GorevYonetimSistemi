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

## Projenin Ekran Görüntüleri ve kullanım senaryoları

Giriş Ekranı:

 ![todogiris](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/e6f7cc35-09e2-4ce6-bbb2-171b53ab4753)

Ana sayfa görüntüsü:

![todoarayuz](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/70b3e42a-e7a9-45f0-98ee-093df20cd0a6)

Görev ekleme işlemi:

![gorevekle](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/daefc17d-33df-4a9f-b0b1-a69435aeb70d)

Görev silme işlemi:

![gorevsil](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/9288c939-9b85-4a20-af27-a889f7320835)

Görev listeleme:

![gorevlistele](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/d5c982aa-dc95-47b5-8ff5-d6020431f88c)

Tamamlandı olarak işaretle:

![todotamamlandı](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/af979f7f-9834-4e7f-8a3d-d4a939787786)

Klasör oluştur:

![klasorolustur](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/8e8adbc9-f622-4f8f-b35f-414ccf00b3b8)

Klasörler:

![klasorler](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/3eeaefe6-aa8b-4565-9d35-26aaf1c5bd93)

-Klasöre görev eklemek:

![folderataskekle](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/64ba361f-d0fc-4cd0-ae2c-e9eded4719b3)

-Klasöre görev eklememek:

![folderataskekleme](https://github.com/merydd/GorevYonetimSistemi/assets/132394236/6f57395e-2ceb-4a48-9396-6227ade7b8cc)

**Özgün katkılar
Özgünlük olarak klasörün içine görev atma seçeneğini ve 'tamamlandı olarak işaretle' işlemini yapınca listeden silinmesi işlemini ekledim. 


