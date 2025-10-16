# OOPBankProject

[TR]

**C# Nesne Yönelimli Programlama (OOP) Kullanılarak Geliştirilmiş Banka Hesabı ve Tasarruf Hesabı Projesi**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/OOPBankProject)](https://github.com/abdullahhaktan/OOPBankProject)

---

## 💻 Proje Hakkında

Bu proje, **C# Nesne Yönelimli Programlama (OOP)** prensiplerini kullanarak bir **banka hesabı simülasyonu** sunar.  
- Temel hesap ve tasarruf hesabı oluşturma  
- Hesap bakiyesi ve minimum bakiye kontrolü  
- Para yatırma ve çekme işlemleri  
- Ay sonu faiz hesaplaması (SavingsAccount)  
- İşlem geçmişi raporlaması  

---

## ✨ Temel Özellikler ve Uygulanan Prensipler

### BankAccount (Temel Hesap)
* **Hesap Numarası:** Otomatik üretilir (`s_accountNumberSeed`)  
* **Bakiye Hesaplama:** Tüm işlemler (`Transaction`) üzerinden dinamik olarak hesaplanır  
* **Para Yatırma / Çekme:** `MakeDeposit` ve `MakeWithdrawal` metodları ile  
* **Minimum Bakiye Kontrolü:** Aşırı çekim engellenir  
* **Ay Sonu İşlemleri:** `PerformMonthEndTransactions` metodunda boş  

### SavingsAccount (Tasarruf Hesabı)
* BankAccount sınıfından türetilmiştir (Inheritance)  
* Sabit faiz oranı (`InterestRate`) ile ay sonunda bakiyeye faiz ekler  
* `PerformMonthEndTransactions` metodu override edilmiştir  

### Transaction (Struct)
* Her işlem için **Miktar, Tarih ve Açıklama** tutulur  
* İşlem geçmişi `GetAccountHistory` metodu ile görüntülenebilir  

---

### Kullanılan Teknolojiler
* **C#** – Programlama dili  
* **.NET** – Çalışma zamanı ve kütüphaneler  
* **OOP Kavramları** – Sınıf, Kalıtım, Polimorfizm, Struct, Exception Handling  

---

## 🚀 Nasıl Çalıştırılır?

1.  **Projeyi Klonlama:**
    ```bash
    git clone https://github.com/abdullahhaktan/OOPBankProject
    cd OOPBankProject
    ```

2.  **Projeyi Açma:**
    * Visual Studio’da `.sln` dosyasını açın  
    * Gerekirse NuGet paketlerini geri yükleyin  

3.  **Projeyi Başlatma:**
    * Ana projeyi **`Startup Project`** olarak ayarlayın  
    * **F5** tuşuna basarak uygulamayı çalıştırın  

---

[EN]

# OOPBankProject

**Bank Account and Savings Account Project Implemented Using C# Object-Oriented Programming (OOP)**

---

## 💻 About the Project

This project demonstrates a **bank account simulation** using **C# Object-Oriented Programming (OOP)** principles.  
- Basic and savings accounts  
- Balance and minimum balance control  
- Deposit and withdrawal transactions  
- End-of-month interest calculation (SavingsAccount)  
- Transaction history reporting  

---

## ✨ Core Features and Applied Principles

### BankAccount (Basic Account)
* **Account Number:** Automatically generated (`s_accountNumberSeed`)  
* **Balance Calculation:** Dynamically computed from all transactions (`Transaction`)  
* **Deposit / Withdrawal:** Using `MakeDeposit` and `MakeWithdrawal` methods  
* **Minimum Balance Check:** Overdraw prevented  
* **Month-End Transactions:** Empty in basic account  

### SavingsAccount
* Inherits from BankAccount  
* Applies **fixed interest rate (`InterestRate`)** at the end of month  
* Overrides `PerformMonthEndTransactions` method  

### Transaction (Struct)
* Stores **Amount, Date, and Note** for each transaction  
* Transaction history available via `GetAccountHistory` method  

---

### Technologies Used
* **C#** – Programming language  
* **.NET** – Runtime and libraries  
* **OOP Concepts** – Class, Inheritance, Polymorphism, Struct, Exception Handling  

---

## 🚀 How to Run

1.  **Cloning the Project:**
    ```bash
    git clone https://github.com/abdullahhaktan/OOPBankProject
    cd OOPBankProject
    ```

2.  **Opening the Project:**
    * Open the `.sln` file in Visual Studio  
    * Restore NuGet packages if needed  

3.  **Starting the Project:**
    * Set the main project as **`Startup Project`**  
    * Press **F5** to run the application  

---

<img width="362" height="420" alt="OOP Bank Screenshot" src="https://github.com/user-attachments/assets/oopbank-screenshot.png" />
