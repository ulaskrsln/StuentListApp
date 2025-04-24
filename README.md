# Basit Öğrenci Yönetim Sistemi (ASP.NET Core MVC & EF Core)

Bu proje, ASP.NET Core MVC ve Entity Framework Core kullanarak basit bir öğrenci yönetim web uygulamasının temel CRUD (Oluştur, Oku, Güncelle, Sil) işlemlerini göstermek amacıyla geliştirilmiştir. Öğrenme ve pratik yapma odaklıdır.

## Projenin Amacı

*   Öğrenci bilgilerini (Ad, Okul Numarası, Bölüm, Sınıf) listelemek.
*   Yeni öğrenci kaydı eklemek.
*   Mevcut öğrenci bilgilerini düzenlemek.
*   Öğrenci kaydını silmek.
*   EF Core'un temel veritabanı işlemlerini (Migrations, DbContext, DbSet, CRUD operasyonları) anlamak.
*   ASP.NET Core MVC'nin temel bileşenlerini (Model, View, Controller, Tag Helpers, Routing, Layout) kullanmak.

## Kullanılan Teknolojiler

*   **.NET 6** (veya projenin geliştirildiği SDK sürümü)
*   **ASP.NET Core MVC**
*   **Entity Framework Core 6** (veya kullanılan sürüm)
*   **SQL Server LocalDB** (Veritabanı olarak)
*   **C#**
*   **HTML / CSS (Bootstrap)** (Varsayılan şablon üzerinden)

## Özellikler

*   **Listeleme:** Tüm kayıtlı öğrencilerin tablo formatında gösterilmesi (`/Student/Index`).
*   **Ekleme:** Yeni öğrenci bilgilerinin girilebileceği bir form (`/Student/Add`) ve bu bilgilerin veritabanına kaydedilmesi.
*   **Düzenleme:** Mevcut bir öğrencinin bilgilerinin form üzerinde güncellenmesi (`/Student/Edit/{id}`).
*   **Silme:** Seçilen bir öğrencinin kaydının onay alınarak veritabanından silinmesi (`/Student/Delete/{id}`).
*   **Navigasyon:** Ana menü üzerinden öğrenci listesi sayfasına kolay erişim.

## Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1.  **Projeyi Klonlayın veya İndirin:**
    *   Bu projenin kodlarını bilgisayarınıza indirin veya Git kullanarak klonlayın.

2.  **Gerekli Yazılımlar:**
    *   **.NET SDK** (Projenin kullandığı sürüm veya daha yenisi) yüklü olmalıdır. ([https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download))
    *   **Visual Studio 2022** (veya uyumlu bir IDE) önerilir. "ASP.NET and web development" iş yükünün yüklü olduğundan emin olun.
    *   **SQL Server LocalDB:** Genellikle Visual Studio ile birlikte yüklenir.

3.  **Projeyi Açın:**
    *   İndirdiğiniz veya klonladığınız klasördeki `.sln` uzantılı solution dosyasını Visual Studio ile açın.

4.  **Veritabanını Oluşturun:**
    *   Visual Studio'da **Tools** -> **NuGet Package Manager** -> **Package Manager Console** (PMC) penceresini açın.
    *   PMC'de projenizin (`EF_Test` veya ne isim verdiyseniz) seçili olduğundan emin olun.
    *   Aşağıdaki komutu çalıştırarak veritabanını ve tabloları oluşturun:
        ```powershell
        Update-Database
        ```
    *   Bu komut, `appsettings.json` dosyasındaki `ConnectionStrings` bölümünde belirtilen (genellikle `(localdb)\mssqllocaldb` üzerinde `EF_Test_Db` gibi bir isimle) veritabanını ve `Migrations` klasöründeki yapıya göre tabloları oluşturacaktır.

5.  **Uygulamayı Çalıştırın:**
    *   Visual Studio'da **F5** tuşuna basarak (Debug modunda) veya **Ctrl+F5** tuşuna basarak (Debug olmadan) uygulamayı başlatın.
    *   Uygulama varsayılan tarayıcınızda açılacaktır.

## Kullanım

*   Uygulama açıldığında ana sayfayı göreceksiniz.
*   Üstteki navigasyon menüsünden "Öğrenciler" (veya eklediğiniz linkin adı) linkine tıklayarak öğrenci listesi sayfasına gidin (`/Student/Index`).
*   **Yeni Öğrenci Ekle:** Liste sayfasının sağ üst köşesindeki "Yeni Öğrenci Ekle" butonuna tıklayın. Formu doldurup "Kaydet" butonuna basın.
*   **Düzenle:** Listede düzenlemek istediğiniz öğrencinin satırındaki "Düzenle" butonuna tıklayın. Formu güncelleyip "Kaydet" butonuna basın.
*   **Sil:** Listede silmek istediğiniz öğrencinin satırındaki "Sil" butonuna tıklayın. Açılan onay sayfasında bilgileri kontrol edip "Sil" butonuna basın.

## Proje Yapısı (Önemli Dosyalar/Klasörler)

*   `/Controllers`: Gelen istekleri işleyen ve yanıtları oluşturan Controller sınıfları (`StudentController.cs`).
*   `/Views`: Kullanıcı arayüzünü oluşturan Razor dosyaları (`/Student/Index.cshtml`, `Add.cshtml`, `Edit.cshtml`, `Delete.cshtml` ve `/Shared/_Layout.cshtml`).
*   `/Models`: Uygulamanın veri yapısını tanımlayan Model sınıfları (`StudentModel.cs`).
*   `/Data`: Veritabanı etkileşimini sağlayan DbContext sınıfı (`ApplicationDbContext.cs`).
*   `/Migrations`: EF Core veritabanı geçiş dosyaları.
*   `Program.cs`: Uygulamanın başlangıç noktası, servislerin ve middleware'lerin yapılandırıldığı yer.
*   `appsettings.json`: Uygulama yapılandırma ayarları (veritabanı bağlantı cümlesi vb.).

---