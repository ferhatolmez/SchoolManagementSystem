# 🏫 Okul Yönetim Sistemi

<div align="center">

[![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://www.microsoft.com/windows)
[![C#](https://img.shields.io/badge/C%23-.NET_4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-F7DF1E?style=for-the-badge)](LICENSE)

> Öğrenci kayıt, öğretmen yönetimi, ders programı, bölüm ve devam takibini tek bir Windows masaüstü uygulamasında birleştiren okul yönetim sistemi.

</div>

---

## ✨ Özellikler

| Modül | İşlevler |
|-------|----------|
| 👨‍🎓 Öğrenci | Kayıt oluşturma, listeleme, güncelleme, silme |
| 👩‍🏫 Öğretmen | Profil yönetimi, tam CRUD desteği |
| 📚 Ders | Ders kataloğu yönetimi |
| 🏛️ Bölüm | Öğrenci-bölüm atama ve takip |
| 📝 Kayıt | Öğrenci kayıt & dönem yönetimi |
| 📅 Devam | Devam durumu (Var/Yok) takibi |
| 📊 Dashboard | Anlık öğrenci, ders, öğretmen ve kayıt sayıları |

---

## ⚙️ Kurulum

### Gereksinimler
- Visual Studio 2019+
- .NET Framework 4.7.2
- Microsoft SQL Server + SSMS

### Adımlar

**1. Repoyu klonlayın**
```bash
git clone https://github.com/ferhatolmez/SchoolManagementSystem.git
```

**2. Veritabanını oluşturun**

SSMS'de aşağıdaki scripti çalıştırın:
```sql
CREATE DATABASE schooldb;
USE schooldb;

CREATE TABLE ogrencitab (OgrenciId INT PRIMARY KEY, OgrenciAd NVARCHAR(100), Tarih DATE, Cinsiyet NVARCHAR(10), Telefon NVARCHAR(20), Email NVARCHAR(100));
CREATE TABLE ogretmentab (OgretmenId INT PRIMARY KEY, OgretmenAd NVARCHAR(100), Cinsiyet NVARCHAR(10), Telefon NVARCHAR(20));
CREATE TABLE derstab (DersId INT PRIMARY KEY, DersAd NVARCHAR(100));
CREATE TABLE bolumtab (BolumId INT PRIMARY KEY, OgrenciAd NVARCHAR(100), Bolum NVARCHAR(100));
CREATE TABLE kayittbl (KId INT PRIMARY KEY, OgrenciAd NVARCHAR(100), Bolum NVARCHAR(100), KayitTarihi DATE);
CREATE TABLE devamtbl (DId INT PRIMARY KEY, OgrenciAd NVARCHAR(100), Durum NVARCHAR(20));
```

**3. Bağlantı dizesini güncelleyin**

Her form dosyasındaki `Data Source` değerini kendi SQL Server instance adınızla değiştirin:
```csharp
// Değiştirin:
@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True"

// Kendi sunucu adınızla:
@"Data Source=SUNUCU_ADINIZ\INSTANCE;Initial Catalog=schooldb;Integrated Security=True"
```

**4. Çözümü açın ve çalıştırın**
```
OkulYonetimSistemi.sln → Ctrl+Shift+B → F5
```

---

## 🤝 Katkıda Bulunma

1. Repoyu fork edin
2. Feature branch oluşturun: `git checkout -b feature/yeni-ozellik`
3. Commit edin: `git commit -m "feat: açıklama"`
4. Push edin ve Pull Request açın

> SQL sorgularında `AddWithValue` ile parametre kullanımını koruyun.

---

## 📄 Lisans

[MIT](LICENSE) © [ferhatolmez](https://github.com/ferhatolmez)

<div align="center">
⭐ Beğendiyseniz yıldız vermeyi unutmayın!
</div>
