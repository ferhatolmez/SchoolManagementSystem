# 🏫 Okul Yönetim Sistemi
### *School Management System*

<div align="center">

[![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://www.microsoft.com/windows)
[![C#](https://img.shields.io/badge/C%23-.NET_4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![Windows Forms](https://img.shields.io/badge/UI-Windows_Forms-68217A?style=for-the-badge&logo=visualstudio&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-F7DF1E?style=for-the-badge)](LICENSE)
[![Build](https://img.shields.io/badge/Build-Passing-2ea44f?style=for-the-badge&logo=github-actions&logoColor=white)](https://github.com/ferhatolmez/SchoolManagementSystem/actions)

<br/>

> **Okul yönetim süreçlerini tek bir masaüstü uygulamada toplayan, öğrenci kayıt, öğretmen atama, ders programı, bölüm yönetimi ve devam takibini entegre biçimde sunan kapsamlı bir Windows Forms uygulaması.**

</div>

---

## 📌 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Teknoloji Yığını](#-teknoloji-yığını)
- [Veritabanı Şeması](#-veritabanı-şeması)
- [Gereksinimler ve Kurulum](#-gereksinimler-ve-kurulum)
- [Kullanım](#-kullanım)
- [Proje Yapısı](#-proje-yapısı)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)
- [İletişim](#-iletişim)

---

## 🎯 Proje Hakkında

**Okul Yönetim Sistemi**, eğitim kurumlarının karmaşık idari süreçlerini basitleştirmek amacıyla geliştirilmiş, C# ve Windows Forms teknolojileriyle inşa edilmiş bir masaüstü uygulamasıdır.

Geleneksel kağıt tabanlı veya dağıtık dijital süreçlerin yarattığı verimsizlik ve hata riskini ortadan kaldırmak için tasarlanan bu sistem; öğrenci bilgileri, öğretmen atamaları, ders müfredatı, bölüm organizasyonu ve devam kayıtlarının tamamını merkezi bir SQL Server veritabanı üzerinden gerçek zamanlı olarak yönetir.

### Neden Bu Proje?

- 📋 Tüm okul verilerini tek bir uygulamada yönetme ihtiyacı
- ⚡ Hızlı CRUD operasyonları ile veri tutarlılığını garantileme
- 📊 Anlık kontrol paneli ile yöneticilere kuş bakışı görünüm sunma
- 🔒 Parametre tabanlı SQL sorguları ile güvenli veri işleme

---

## ✨ Özellikler

### 👨‍🎓 Öğrenci Yönetimi (`ogrencitab`)
- Yeni öğrenci kaydı oluşturma (ID, Ad, Doğum Tarihi, Cinsiyet, Telefon, E-posta)
- Mevcut öğrenci bilgilerini görüntüleme, güncelleme ve silme
- DataGridView ile tüm öğrenci listesini tablo formatında görüntüleme
- Tarih seçici ile doğrulama destekli doğum tarihi girişi

### 👩‍🏫 Öğretmen Yönetimi (`ogretmentab`)
- Öğretmen kaydı ve profil yönetimi (ID, Ad, Cinsiyet, Telefon)
- Tam CRUD (Create, Read, Update, Delete) desteği
- Anlık liste görünümü ile öğretmen veritabanına erişim

### 📚 Ders Yönetimi (`derstab`)
- Okuldaki tüm derslerin katalog yönetimi
- Ders ekleme, güncelleme ve silme
- Ders listesi görüntüleme

### 🏛️ Bölüm Yönetimi (`bolumtab`)
- Akademik bölümlerin ve öğrenci-bölüm ilişkilerinin yönetimi
- Bölüm bazında öğrenci atama ve takip

### 📝 Kayıt / Enrollment Yönetimi (`kayittbl`)
- Öğrenci-bölüm kayıt işlemleri
- Kayıt tarihi takibi ile akademik dönem yönetimi

### 📅 Devam Takibi (`devamtbl`)
- Öğrenci devam durumu kaydı (Var/Yok)
- Devam kayıtlarını listeleme, güncelleme ve silme

### 📊 Kontrol Paneli (`KontrolPaneli`)
- Gerçek zamanlı özet istatistikler:
  - Toplam öğrenci sayısı
  - Toplam ders sayısı
  - Toplam öğretmen sayısı
  - Toplam kayıt sayısı

---

## 📸 Ekran Görüntüleri

> 📌 *Ekran görüntülerini `docs/screenshots/` klasörüne ekleyerek aşağıdaki yorum satırlarını aktif hale getirebilirsiniz.*

<!--
| Ana Menü | Kontrol Paneli |
|:---:|:---:|
| ![Ana Menü](docs/screenshots/main.png) | ![Dashboard](docs/screenshots/dashboard.png) |

| Öğrenci Yönetimi | Öğretmen Yönetimi |
|:---:|:---:|
| ![Öğrenci](docs/screenshots/ogrenci.png) | ![Öğretmen](docs/screenshots/ogretmen.png) |
-->

---

## 🛠️ Teknoloji Yığını

| Katman | Teknoloji | Sürüm |
|--------|-----------|-------|
| **Dil** | C# | — |
| **Framework** | .NET Framework | 4.7.2 |
| **UI** | Windows Forms (WinForms) | — |
| **Veritabanı** | Microsoft SQL Server | 2016+ |
| **Veri Erişimi** | ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) | — |
| **IDE** | Visual Studio | 2019+ |
| **CI/CD** | GitHub Actions | — |

---

## 🗃️ Veritabanı Şeması

Uygulama `schooldb` adlı SQL Server veritabanını kullanır. Aşağıdaki tabloları içerir:

```sql
-- Öğrenci Tablosu
CREATE TABLE ogrencitab (
    OgrenciId   INT PRIMARY KEY,
    OgrenciAd   NVARCHAR(100),
    Tarih       DATE,
    Cinsiyet    NVARCHAR(10),
    Telefon     NVARCHAR(20),
    Email       NVARCHAR(100)
);

-- Öğretmen Tablosu
CREATE TABLE ogretmentab (
    OgretmenId  INT PRIMARY KEY,
    OgretmenAd  NVARCHAR(100),
    Cinsiyet    NVARCHAR(10),
    Telefon     NVARCHAR(20)
);

-- Ders Tablosu
CREATE TABLE derstab (
    DersId      INT PRIMARY KEY,
    DersAd      NVARCHAR(100)
);

-- Bölüm Tablosu
CREATE TABLE bolumtab (
    BolumId     INT PRIMARY KEY,
    OgrenciAd   NVARCHAR(100),
    Bolum       NVARCHAR(100)
);

-- Kayıt Tablosu
CREATE TABLE kayittbl (
    KId             INT PRIMARY KEY,
    OgrenciAd       NVARCHAR(100),
    Bolum           NVARCHAR(100),
    KayitTarihi     DATE
);

-- Devam Tablosu
CREATE TABLE devamtbl (
    DId         INT PRIMARY KEY,
    OgrenciAd   NVARCHAR(100),
    Durum       NVARCHAR(20)
);
```

---

## ⚙️ Gereksinimler ve Kurulum

### 📋 Ön Gereksinimler

Başlamadan önce aşağıdaki araçların sisteminizde kurulu olduğundan emin olun:

| Araç | Minimum Sürüm | İndirme |
|------|---------------|---------|
| Visual Studio | 2019 | [visualstudio.microsoft.com](https://visualstudio.microsoft.com/) |
| .NET Framework | 4.7.2 | Windows Update veya Visual Studio ile gelir |
| SQL Server | 2016 | [microsoft.com/sql-server](https://www.microsoft.com/sql-server) |
| SQL Server Management Studio (SSMS) | Herhangi | [SSMS İndirme](https://aka.ms/ssmsfullsetup) |
| Git | Herhangi | [git-scm.com](https://git-scm.com/) |

---

### 🚀 Adım Adım Kurulum

#### 1️⃣ Repoyu Klonlayın

```bash
git clone https://github.com/ferhatolmez/SchoolManagementSystem.git
cd SchoolManagementSystem
```

#### 2️⃣ Veritabanını Kurun

SQL Server Management Studio'yu açın ve aşağıdaki adımları izleyin:

```sql
-- 1. Yeni bir veritabanı oluşturun
CREATE DATABASE schooldb;
USE schooldb;

-- 2. Yukarıdaki "Veritabanı Şeması" bölümündeki CREATE TABLE komutlarını çalıştırın
```

#### 3️⃣ Bağlantı Dizesini Yapılandırın

Projedeki tüm form dosyalarında (`Ogrenci.cs`, `Ogretmen.cs`, `Kayit.cs`, vb.) bağlantı dizesi şu şekilde tanımlanmıştır:

```csharp
// MEVCUT (değiştirmeniz gereken)
SqlConnection con = new SqlConnection(
    @"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True"
);

// GÜNCEL (kendi sunucu adınızla)
SqlConnection con = new SqlConnection(
    @"Data Source=YOUR_SERVER_NAME\YOUR_INSTANCE;Initial Catalog=schooldb;Integrated Security=True"
);
```

> 💡 **İpucu:** Sunucu adınızı bulmak için SSMS'i açın; bağlantı ekranında gördüğünüz değer sizin `Data Source` değerinizdir.

> 🔐 **Güvenlik Notu:** Bağlantı dizelerini ilerleyen sürümlerde `App.config` veya `appsettings.json` gibi merkezi bir yapılandırma dosyasına taşımanız önerilir.

#### 4️⃣ Projeyi Visual Studio'da Açın

```
Dosya → Aç → Proje/Çözüm → OkulYonetimSistemi.sln
```

#### 5️⃣ Çözümü Derleyin ve Çalıştırın

```
Derleme → Çözümü Derle  (Ctrl + Shift + B)
Hata Ayıklama → Hata Ayıklamayı Başlat  (F5)
```

---

## 🖥️ Kullanım

Uygulama başlatıldığında **Ana Menü** ekranı açılır. Buradan tüm modüllere erişebilirsiniz:

```
┌─────────────────────────────────────────┐
│           OKul YÖNETİM SİSTEMİ         │
├─────────────────────────────────────────┤
│  [👨‍🎓 Öğrenci]     [👩‍🏫 Öğretmen]        │
│  [📚 Ders]         [🏛️ Bölüm]           │
│  [📝 Kayıt]        [📅 Devam]           │
│  [📊 Kontrol Paneli]                    │
└─────────────────────────────────────────┘
```

### Temel İş Akışları

**Yeni Öğrenci Ekleme:**
1. Ana Menü → `Öğrenci` butonuna tıklayın
2. Öğrenci ID, Ad, Doğum Tarihi, Cinsiyet, Telefon ve E-posta alanlarını doldurun
3. `Kaydet` butonuna tıklayın → Başarı mesajı görüntülenir
4. `Görüntüle` ile tabloda tüm kayıtları listeleyin

**Devam Kaydı Oluşturma:**
1. Ana Menü → `Devam` modülüne gidin
2. Devam ID, Öğrenci Adı ve Durum (örn. `Var` / `Yok`) bilgilerini girin
3. `Kaydet` ile kaydı oluşturun

**Kontrol Panelini Görüntüleme:**
1. Ana Menü → `Kontrol Paneli` butonuna tıklayın
2. Anlık öğrenci, ders, öğretmen ve kayıt sayılarını görün

---

## 📁 Proje Yapısı

```
SchoolManagementSystem/
├── .github/
│   └── workflows/
│       └── dotnet-desktop.yml       # CI/CD pipeline
├── OkulYonetimSistemi/
│   ├── Program.cs                   # Uygulama giriş noktası
│   ├── Form1.cs / Form1.Designer.cs # Giriş formu
│   ├── Main.cs / Main.Designer.cs   # Ana menü
│   ├── KontrolPaneli.cs             # Dashboard / Özet istatistikler
│   ├── Ogrenci.cs                   # Öğrenci CRUD modülü
│   ├── Ogretmen.cs                  # Öğretmen CRUD modülü
│   ├── Konu.cs                      # Ders CRUD modülü
│   ├── Bolum.cs                     # Bölüm CRUD modülü
│   ├── Kayit.cs                     # Kayıt CRUD modülü
│   ├── Devamlilik.cs                # Devam CRUD modülü
│   ├── Properties/
│   │   ├── AssemblyInfo.cs
│   │   └── Resources.resx
│   ├── Resources/                   # Uygulama görselleri
│   ├── App.config
│   └── OkulYonetimSistemi.csproj
└── OkulYonetimSistemi.sln           # Visual Studio çözüm dosyası
```

---

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Bu projeye katkıda bulunmak için aşağıdaki adımları izleyin:

### Katkı Süreci

**1. Fork & Clone**
```bash
# Repoyu fork edin (GitHub arayüzünden)
git clone https://github.com/KULLANICI_ADINIZ/SchoolManagementSystem.git
cd SchoolManagementSystem
```

**2. Feature Branch Oluşturun**
```bash
# Her yeni özellik veya düzeltme için ayrı bir dal açın
git checkout -b feature/ogrenci-arama-filtresi
# veya
git checkout -b fix/baglanti-dizesi-yapisi
```

**3. Değişikliklerinizi Yapın ve Commit Edin**
```bash
git add .
git commit -m "feat: öğrenci listesine ada göre arama filtresi eklendi"
```

> **Commit mesajı formatı:** `<tip>: <kısa açıklama>`
> Tipler: `feat`, `fix`, `docs`, `refactor`, `test`, `chore`

**4. Push ve Pull Request**
```bash
git push origin feature/ogrenci-arama-filtresi
```
GitHub üzerinden `master` branch'ine Pull Request açın.

### ✅ Katkı Kuralları

- Her modül için mevcut CRUD yapısına uygun kod yazın
- SQL sorgularında mutlaka **parametre kullanımı** (`AddWithValue`) tercih edin — SQL injection'a karşı
- Türkçe değişken ve form adlandırma geleneğine uyun
- Büyük değişiklikler için önce bir **Issue** açarak tartışın
- PR açıklamasında yaptığınız değişikliği net biçimde belirtin

### 🐛 Hata Bildirimi

Bir hata bulduysanız [Issues](https://github.com/ferhatolmez/SchoolManagementSystem/issues) sayfasından yeni bir issue açın ve şu bilgileri ekleyin:

- İşletim sistemi ve .NET Framework sürümü
- SQL Server sürümü
- Hatanın adımlar ile tekrar üretilmesi
- Hata mesajı veya ekran görüntüsü

---

## 📄 Lisans

Bu proje **MIT Lisansı** ile lisanslanmıştır.

```
MIT License

Copyright (c) 2024 ferhatolmez

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 📬 İletişim

**Ferhat Ölmez**

[![GitHub](https://img.shields.io/badge/GitHub-ferhatolmez-181717?style=flat-square&logo=github)](https://github.com/ferhatolmez)

---

<div align="center">

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!

*Made with ❤️ using C# & Windows Forms*

</div>
