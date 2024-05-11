# AutoCare Scheduler - Araç Bakım Randevu Sistemi

Bu proje, Nesne Yönelimli Programlama prensiplerini kullanarak geliştirilmiş bir araç bakım randevu sistemi uygulamasıdır. Veritabanını oluşturduktan sonra kullanıcı adı ve şifreyi *admin* girerek giriş işlemi yapabilirsiniz.

## Projenin Genel Mimarisi

### Business Katmanı
Bu katman, uygulamanın iş mantığını uygulayan ve veritabanı işlemlerini koordine eden sınıfları içerir. Her bir yönetici sınıfı, belirli bir veri türü üzerinde işlemleri gerçekleştirir. Örneğin, `AppointmentManager` sınıfı, randevu verileri üzerinde işlemleri gerçekleştirir.

### Contracts Katmanı
Bu katman, farklı katmanlar arasında bir arayüz sağlar. Genellikle iş mantığını uygulayan Business katmanı ile veritabanı işlemlerini gerçekleştiren Data katmanı arasında bir köprü görevi görür. Contracts katmanındaki arayüzler, farklı katmanların birbirleriyle etkileşimini soyutlar.

### Data Katmanı
Bu katman, genellikle veritabanı işlemlerinin gerçekleştirildiği katmandır. Veritabanı ile iletişim sağlayan sınıflar ve metotlar bulunur. Bu katman, veri alma, ekleme, güncelleme ve silme gibi işlemleri gerçekleştirir.

### Forms Katmanı
Bu katman, kullanıcı arayüzünü temsil eden formları içerir. Her form, belirli bir kullanıcı arayüzünü temsil eder.

![Login Sayfası](https://github.com/ramazang0kmen/AutoCare-Scheduler---Ara-Bak-m-Randevu-Sistemi/blob/master/AutoCare%20Scheduler%20-%20Ara%C3%A7%20Bak%C4%B1m%20Randevu%20Sistemi/Resource/login.png)

![Panel Sayfası](https://github.com/ramazang0kmen/AutoCare-Scheduler---Ara-Bak-m-Randevu-Sistemi/blob/master/AutoCare%20Scheduler%20-%20Ara%C3%A7%20Bak%C4%B1m%20Randevu%20Sistemi/Resource/panel.png)

![Ana Sayfa](https://github.com/ramazang0kmen/AutoCare-Scheduler---Ara-Bak-m-Randevu-Sistemi/blob/master/AutoCare%20Scheduler%20-%20Ara%C3%A7%20Bak%C4%B1m%20Randevu%20Sistemi/Resource/home.png)

### Helpers Katmanı
Bu katman, yardımcı işlevleri sağlayan sınıfları içerir. Dosya işlemleri, şifreleme, hata kayıtları gibi işlevleri gerçekleştirir.

### Model Katmanı
Bu katman, veritabanındaki tabloların alanlarını ve ilişkilerini temsil eden sınıfları içerir. Veri yapıları tanımlanır ve verilerin işlenmesi için kullanılır.

Detaylı bilgi için [proje belgesine](https://github.com/ramazang0kmen/AutoCare-Scheduler---Ara-Bak-m-Randevu-Sistemi) göz atabilirsiniz.

### Veri Tabanı Oluşturma

```sql
USE master;
GO

-- Veritabanını oluştur
CREATE DATABASE AutoCareSchedulerDb;
GO

USE AutoCareSchedulerDb;
GO

-- Appointment tablosunu oluştur
CREATE TABLE [dbo].[Appointment](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [CustomerId] [int] NOT NULL,
    [ServiceId] [int] NOT NULL,
    [OperationId] [int] NOT NULL,
    [PersonnelId] [int] NOT NULL,
    [Date] [datetime] NOT NULL,
    [TotalPrice] [decimal](18, 0) NOT NULL,
    [Description] [varchar](500) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Customer tablosunu oluştur
CREATE TABLE [dbo].[Customer](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [NameSurname] [varchar](100) NOT NULL,
	  [PhoneNumber] [varchar](14) NOT NULL,
	  [EmailAddress] [varchar](100) NOT NULL,
	  [Address] [varchar](500) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Operation tablosunu oluştur
CREATE TABLE [dbo].[Operation](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](100) NOT NULL,
	  [Price] [decimal](18, 0) NOT NULL,
	  [Description] [varchar](500) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Personnel tablosunu oluştur
CREATE TABLE [dbo].[Personnel](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [NameSurname] [varchar](100) NOT NULL,
	  [username] [varchar](50) NOT NULL,
	  [Password] [varchar](100) NOT NULL,
	  [Department] [varchar](100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Service tablosunu oluştur
CREATE TABLE [dbo].[Service](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](100) NOT NULL,
	  [Address] [varchar](50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Personnel tablosuna admin personelini ekle
INSERT INTO [dbo].[Personnel] ([NameSurname], [username], [Password], [Department])
VALUES ('admin', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'admin');

