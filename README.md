# TryCath Projesi

Bu proje, kullanıcıdan sürekli olarak sayı girişi isteyen ve girilen sayının karesini hesaplayan bir C# uygulamasıdır. Geçersiz bir girdi (sayı formatında olmayan bir değer) girildiğinde, hata yakalanarak kullanıcı bilgilendirilir.

## Çalışma Mantığı
- Program sonsuz bir `while` döngüsü içinde çalışır.
- Kullanıcıdan bir sayı girmesi istenir.
- Girilen değer `int` formatında bir sayıya dönüştürülmeye çalışılır.
  - Geçerli bir sayı girilirse, sayının karesi hesaplanır ve ekrana yazdırılır.
  - Geçersiz bir girdi girilirse, bir `FormatException` yakalanır ve kullanıcıya "Lütfen geçerli bir sayı girin!" mesajı görüntülenir.

## Kod Yapısı
### Program Kodu:
```csharp
using System;
namespace TryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Lütfen bir sayı giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    int sayininKaresi = sayi * sayi;
                    Console.WriteLine(sayininKaresi);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin!");
                }
            }
        }
    }
}
```

## Kullanım
1. **Programı Çalıştırın:**
   - Proje Visual Studio gibi bir C# geliştirme ortamında çalıştırılabilir.

2. **Sonsuz Döngü:**
   - Program kullanıcıdan tekrar tekrar sayı girmesini ister.
   - Kullanıcı doğru bir sayı girerse, karesi hesaplanır ve ekrana yazdırılır.
   - Geçersiz bir girdi girilirse, hata yakalanır ve kullanıcı bilgilendirilir.

3. **Programı Durdurmak:**
   - Program sonsuz bir döngüde çalıştığı için elle durdurulması gerekir (Ctrl + C).

## Çıktı Örnekleri
### Geçerli Girdi:
**Girdi:** `5`  
**Çıktı:** `25`

**Girdi:** `-3`  
**Çıktı:** `9`

### Geçersiz Girdi:
**Girdi:** `abc`  
**Çıktı:** `Lütfen geçerli bir sayı girin!`

**Girdi:** ` ` (boş girdi)  
**Çıktı:** `Lütfen geçerli bir sayı girin!`

## Geliştirme Önerileri
- **Döngüyü Sonlandırma:** Kullanıcı "çık" yazdığında program sonlandırılabilir.
- **Diğer Hata Kontrolleri:** `OverflowException` gibi diğer olası hataları da ele alacak şekilde genisletilebilir.
- **Girilen Değerin Boş Olması:** Boş bir girdi yapılırsa, bunun için ayrı bir kontrol eklenebilir.

## Lisans
Bu proje MIT Lisansı altında sunulmuştur.

