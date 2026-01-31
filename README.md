🚀 ASP.NET Core MVC Projemi Paylaşıyorum! 👗

MODERN ELBİSE MARKET – Elbise Yönetim Sistemi

Bu proje, ASP.NET Core MVC ile geliştirdiğim modern ve kullanıcı odaklı bir web uygulamasıdır.
Amacım; MVC mimarisini daha iyi kavrayarak LINQ tabanlı veri yönetimi ile temiz, okunabilir ve sürdürülebilir bir yapı oluşturmaktı.

Projede elbise kayıtlarını yöneten, tam CRUD desteğine sahip bir yönetim sistemi geliştirdim.
Filtreleme işlemlerini LINQ kullanarak fiyat, renk ve beden bazlı olacak şekilde ele aldım ve kullanıcıya dinamik bir listeleme deneyimi sundum.

🔧 Teknik Detaylar

* ASP.NET Core MVC
* C#
* Entity Framework Core
* LINQ ile veri sorgulama ve filtreleme
* Bootstrap 5
* HTML / CSS / Vanilla JavaScript

⚙️ Öne Çıkan Noktalar

* MVC pattern’in birebir uygulanm…
 👗 Elbise Yönetim Sistemi
ASP.NET Core MVC 9.0 ile geliştirilmiş, modern ve şık bir elbise koleksiyonu yönetim uygulaması.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-purple)
![C#](https://img.shields.io/badge/C%23-12.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)

## ✨ Özellikler

### 🎨 Modern Kullanıcı Arayüzü
- **Responsive Design**: Tüm cihazlarda mükemmel görüntüleme
- **Neon Efektler**: Profesyonel glow ve shadow efektleri
- **Smooth Animations**: Akıcı geçiş animasyonları

### 🔍 Gelişmiş Filtreleme Sistemi
- **Fiyat Filtreleri**: 
  - Ucuz (150₺ altı)
  - Orta (150-200₺)
  - Pahalı (200₺ üstü)
- **Renk Filtreleri**: Kırmızı, Mavi, Siyah, Beyaz
- **Beden Filtreleri**: S, M, L, XL
- **LINQ Sorguları**: Performanslı veri filtreleme

### 📋 CRUD İşlemleri
- ➕ **Ekleme**: Yeni elbise kaydı oluşturma
- ✏️ **Güncelleme**: Mevcut kayıtları düzenleme
- 🗑️ **Silme**: Onay ile güvenli silme
- 📊 **Listeleme**: Tüm kayıtları görüntüleme ve filtreleme

### 💾 Veri Yönetimi
- In-Memory veri saklama
- Model bazlı veri yapısı
- Validation desteği

## 🛠️ Teknolojiler

### Backend
- **ASP.NET Core MVC 9.0**
- **LINQ** - Veri sorgulama
- **Razor Pages** - View engine


## 📁 Proje Yapısı

```
deneme/
├── Controllers/
│   ├── ElbiseController.cs      # Ana controller (CRUD + Filtreleme)
│   └── HomeController.cs        # Ana sayfa controller
├── Models/
│   ├── Elibse.cs               # Elbise model sınıfı
│   └── ErrorViewModel.cs        # Hata modeli
├── Views/
│   ├── Elbise/
│   │   ├── List.cshtml         # Liste görünümü (Filtreler + Tablo)
│   │   ├── Create.cshtml       # Ekleme formu
│   │   └── Edit.cshtml         # Güncelleme formu
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── Error.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
├── Program.cs                   # Uygulama giriş noktası
└── README.md
```

## 💡 Kullanım

### Elbise Ekleme
1. "Yeni Elbise" butonuna tıklayın
2. Formu doldurun (ID, Renk, Beden, Fiyat, Model)
3. "Kaydet" butonuna tıklayın

### Filtreleme
- **Fiyat Filtresi**: İstediğiniz fiyat aralığını seçin
- **Renk Filtresi**: Belirli bir rengi seçin
- **Beden Filtresi**: İstediğiniz bedeni seçin
- **Tümü**: Tüm filtreleri temizle

### Güncelleme
1. Listeden "Güncelle" butonuna tıklayın
2. Bilgileri düzenleyin
3. "Güncelle" butonuna tıklayın

### Silme
1. Listeden "Sil" butonuna tıklayın
2. Onay dialogunu kabul edin



### Efektler
- Glow shadows
- Smooth hover transitions
- Gradient borders
- Backdrop blur

## 📊 Veri Modeli

```csharp
public class Elbise
{
    public int Id { get; set; }
    public string Renk { get; set; }
    public string Beden { get; set; }
    public decimal Fiyat { get; set; }
    public string Model { get; set; }
}
```




## 📸 Ekran Görüntüleri

### Ana Liste Sayfası
Modern filtreleme sistemi ve şık tablo tasarımı ile elbise koleksiyonunuzu yönetin.

### Ekleme Formu
Kullanıcı dostu form tasarımı ile hızlı ve kolay elbise ekleme.

### Güncelleme Formu
Mevcut kayıtları kolayca düzenleyin.


## ⚡ Performans

- LINQ ile optimize edilmiş sorgular
- Minimal JavaScript kullanımı
- CSS3 ile donanım hızlandırmalı animasyonlar
- Responsive images


⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
