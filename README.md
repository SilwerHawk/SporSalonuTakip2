Spor Salonu Takip Projesi

Bu proje, spor salonuna ait üye ve antrenör bilgilerinin takibini kolaylaştırmak amacıyla hazırlanmış bir WinForms uygulamasıdır. Çalışmada öncelikli olarak tasarım ve temel sınıf yapıları üzerinde durulmuştur.

Proje başlatıldıktan sonra anasayfada belirtilen adımlar takip edilerek gerekli UserControl bileşenleri oluşturulmuştur.  
Kod tarafında ise interface yapısı kullanılarak modüler ve geliştirilmeye uygun bir yapı hedeflenmiştir.

Sınıf ve Yapı Detayları

UyeveAntronorOrtakOzellilkleri (Interface)  
Ortak özelliklerin tanımlanması için oluşturulmuştur.  
Bu arabirimden türeyen sınıflar:  
Uye  
Antronor

Uye Sınıfı  
Üyelere özel olarak Kilo ve Boy özellikleri eklenmiştir.  
Get / Set yapılarıyla boş ya da hatalı veri girişleri engellenmiştir.

Antronor Sınıfı  
Uzmanlık ve TecrubeYılı özellikleri tanımlanmıştır.  
Veri doğrulaması yine Get / Set bloklarıyla sağlanmıştır.

RenkDegistir  
Anasayfadaki butonlara tıklanınca renk değiştirme özelliği kazandırılmıştır.  
Ayrıca sorgulama ekranlarındaki DataGridView bileşenlerine daha modern bir görünüm verilmiştir.

PanelDegistir  
Farklı sayfalar (UserControl’lar) arasında geçiş yapılabilmesi için gerekli metotlar yazılmıştır.  
Panel geçiş yapısı, çeşitli örnek projeler ve eğitim videoları incelenerek geliştirilmiştir.

Veritabanislemleri  
Kayıt ve sorgulama işlemlerini gerçekleştirmek için oluşturulmuştur.  
Henüz veritabanı konusu tam olarak işlenmediği için bu sınıf farklı kaynaklardan yararlanılarak hazırlanmıştır.

Kullanıcı Arayüzü (UserControls)

Projede aşağıdaki dört temel modül bulunmaktadır:

Antrenorekle  
Uyeekle  
Sorgulama  
Programekle

Bu UserControl’larda kullanıcıdan alınan bilgiler, daha önce oluşturulan sınıflar aracılığıyla kontrol edilmekte ve hatalı veri girişlerinin önüne geçilmektedir.

Son kontroller yapıldıktan sonra proje tamamlanmış ve commit işlemi gerçekleştirilmiştir.
