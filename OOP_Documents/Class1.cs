using System;
using System.Collections.Generic; // Adım 5 için gerekli
using OOP_Documents; // BankAccount ve SavingsAccount sınıflarınızın bulunduğu yer

namespace OOP_Documents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Yorum satırlarını kaldırmak için Ctrl+K, Ctrl+U (Visual Studio) kullanabilirsiniz.
            // Sadece tek bir bloktaki yorum satırlarını kaldırıp çalıştırmanız önerilir.

            // ----------------------------------------------------------------------------------

            // Adım 1: Temel Fonksiyonellik ve İstisna Testleri (ArgumentOutOfRangeException ve InvalidOperationException)
            // ----------------------------------------------------------------------------------
            /*
            Console.WriteLine("--- Adım 1 Testi: Temel Fonksiyonellik ve İstisnalar ---");

            // Geçerli bir hesap oluşturun
            var account = new BankAccount("Mustafa Ozel", 1000);

            Console.WriteLine($"Hesap Numarası: {account.Number}, Sahibi: {account.Owner}, Bakiye: {account.Balance:C}");

            // Negatif başlangıç bakiyesini test edin (Yapıcı metot hata fırlatmalı)
            Console.WriteLine("\n--- Negatif Bakiye Oluşturma Testi ---");
            try
            {
                var invalidAccount = new BankAccount("geçersiz deneme", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Hata yakalandı: Negatif bakiye ile hesap oluşturulamadı.");
                Console.WriteLine("------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("------------------");
            }

            // Yeterli bakiye olmamasına rağmen para çekmeyi deneyin (MakeWithdrawal hata fırlatmalı)
            Console.WriteLine("\n--- Aşırı Çekim Testi ---");
            try
            {
                // Mevcut bakiye 1000. 1050 çekmeye çalışarak aşırı çekimi tetikleyelim.
                account.MakeWithdrawal(1050, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Hata yakalandı: Aşırı çekim denemesi engellendi.");
                Console.WriteLine(e.Message);
            }

            // Başarılı bir çekim yapalım (kontrolün çalıştığını göstermek için)
            Console.WriteLine("\n--- Başarılı Çekim Testi ---");
            account.MakeWithdrawal(50, DateTime.Now, "Başarılı Çekim");

            // Hesap durumunu yazdırın
            Console.WriteLine($"\nGüncel Bakiye: {account.Balance:C}");

            // İşlem geçmişini yazdıralım
            Console.WriteLine("\n--- İşlem Geçmişi ---");
            Console.WriteLine(account.GetAccountHistory());
            */

            // ----------------------------------------------------------------------------------
            // Adım 2: Hesap Numarası Üretimi Testi (s_accountNumberSeed)
            // ----------------------------------------------------------------------------------
            /*
            Console.WriteLine("--- Adım 2 Testi: Otomatik Hesap Numarası Oluşturma ---");
            
            var account1 = new BankAccount("Hesap 1 Sahibi", 500);
            var account2 = new BankAccount("Hesap 2 Sahibi", 200);
            var account3 = new BankAccount("Hesap 3 Sahibi", 100);

            Console.WriteLine($"Hesap 1 Numarası: {account1.Number}");
            Console.WriteLine($"Hesap 2 Numarası: {account2.Number}");
            Console.WriteLine($"Hesap 3 Numarası: {account3.Number}");

            Console.WriteLine("\n--- Kontrol ---");
            Console.WriteLine($"Hesap 1 Numarası (Beklenen: 1234567890) Eşleşiyor mu? {account1.Number == "1234567890"}");
            Console.WriteLine($"Hesap 2 Numarası (Beklenen: 1234567891) Eşleşiyor mu? {account2.Number == "1234567891"}");
            Console.WriteLine($"Hesap 3 Numarası (Beklenen: 1234567892) Eşleşiyor mu? {account3.Number == "1234567892"}");
            */

            // ----------------------------------------------------------------------------------
            // Adım 3: Minimum Bakiye Kontrolü Testi (Devralmaya Hazırlık)
            // ----------------------------------------------------------------------------------
            /*
            Console.WriteLine("--- Adım 3 Testi: Minimum Bakiye Kontrolü (0) ---");
            
            // Yeni yapıcıyı kullanan bir hesap oluşturuldu
            var account = new BankAccount("Test Hesabı", 100);

            Console.WriteLine($"Bakiye: {account.Balance:C}");
            
            try
            {
                // Mevcut bakiye 100. 101 çekmeye çalışarak aşırı çekimi tetikleyelim.
                // CheckWithdrawalLimit virtual metodu çalışır.
                account.MakeWithdrawal(101, DateTime.Now, "Minimum bakiye aşımı denemesi");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Hata yakalandı: Aşırı çekim denemesi engellendi.");
                Console.WriteLine(e.Message);
            }

            // Başarılı bir işlem yapalım
            account.MakeWithdrawal(50, DateTime.Now, "Başarılı Çekim");

            Console.WriteLine($"\nGüncel Bakiye (50 olmalı): {account.Balance:C}");
            */

            // ----------------------------------------------------------------------------------
            // Adım 4: Tasarruf Hesabı (SavingsAccount) ve Faiz Uygulaması Testi
            // Not: Bu kod bloğu, sizin son olarak paylaştığınız bloktur.
            // ----------------------------------------------------------------------------------
            /*
            Console.WriteLine("--- Adım 4 Testi: Faiz Uygulaması ---");
            
            var saving = new SavingsAccount("Abdullah Haktan", 1000);

            Console.WriteLine($"Hesap Sahibi: {saving.Owner}");
            Console.WriteLine($"Başlangıç Bakiyesi: {saving.Balance:C}");
            Console.WriteLine($"Faiz Oranı:{SavingsAccount.InterestRate:P}"); // :P formatı yüzde gösterir

            // Önce bir çekim yapalım ki faiz hesabı doğru olsun (Daha doğru bir test için eklenmiştir)
            saving.MakeWithdrawal(50, DateTime.Now, "Fatura Ödemesi"); // Bakiye 950 oldu

            saving.PerformMonthEndTransactions();

            // Beklenen bakiye hesaplaması (Faiz oranı 0.025m kabul edilirse)
            decimal expectedBalance = 950m + (950m * SavingsAccount.InterestRate); 

            Console.WriteLine("\nAy Sonu İşlemi Yapıldı.");
            Console.WriteLine($"Güncel Bakiye (Beklenen: {expectedBalance:C}): {saving.Balance:C}");

            // İşlem geçmişini kontrol edelim
            Console.WriteLine("\n--- İşlem Geçmişi ---");
            Console.WriteLine(saving.GetAccountHistory());
            */

            // ----------------------------------------------------------------------------------
            // Adım 5: Polimorfizm Testi (Final Kodu)
            // ----------------------------------------------------------------------------------

            Console.WriteLine("--- OOP Banka Hesabı Projesi Başladı ---");

            // BankAccount tipinde bir liste oluşturun. (Polimorfizm)
            var accounts = new List<BankAccount>
            {
                // 1. Temel Hesap (Faiz yok)
                new BankAccount("Temel Hesap Sahibi", 500), 
                
                // 2. Tasarruf Hesabı (Faiz var)
                new SavingsAccount("Faizli Hesap Sahibi", 1000)
            };

            // Farklı tipteki hesaplar üzerinde işlemler gerçekleştirin
            accounts[0].MakeWithdrawal(50, DateTime.Now, "Temel Hesap Çekim");
            accounts[1].MakeDeposit(200, DateTime.Now, "Faizli Hesap Yatırım");

            Console.WriteLine("\n--- Ay Sonu İşlemleri Başlıyor (Polimorfizm Testi) ---");

            // Ay sonu işlemlerini başlatın. 
            foreach (var account in accounts)
            {
                // Çalışma zamanında (Runtime) doğru metot (virtual veya override) çağrılır.
                account.PerformMonthEndTransactions();
            }

            Console.WriteLine("\nAy Sonu İşlemleri Tamamlandı. Sonuçlar:");

            // Sonuçları yazdırın
            foreach (var account in accounts)
            {
                Console.WriteLine($"\n--- {account.Owner} ---");
                Console.WriteLine($"Hesap Numarası: {account.Number}");
                Console.WriteLine($"Güncel Bakiye: {account.Balance:C}");
                Console.WriteLine($"İşlem Geçmişi:\n{account.GetAccountHistory()}");
            }
        }
    }
}