/****************************************************************************
** DÜZCE ÜNİVERSİTESİ
** Lisansüstü Eğitim Enstitüsü
** Yüksek Lisans Enstitüsü Anabilim Dalı Bilgisayar Mühendisliği BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2023-2024 BAHAR DÖNEMİ
**
**
** ÖĞRENCİ ADI............: RAMAZAN GÖKMEN
** ÖĞRENCİ NUMARASI.......: 2345007015
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/

using Microsoft.EntityFrameworkCore;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Data
{
    // Veritabanı işlemlerini gerçekleştirmek için Entity Framework Core DbContext sınıfını genişletir.
    public class DataContext : DbContext
    {
        // DataContext sınıfının kurucu metodudur. DbContextOptions nesnesi alır.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Veritabanında müşterilerle ilgili tabloya erişimi sağlar.
        public DbSet<Model.Customer> Customers { get; set; }

        // Veritabanında işlemlerle ilgili tabloya erişimi sağlar.
        public DbSet<Model.Operation> Operations { get; set; }

        // Veritabanında personellerle ilgili tabloya erişimi sağlar.
        public DbSet<Model.Personnel> Personnels { get; set; }

        // Veritabanında hizmetlerle ilgili tabloya erişimi sağlar.
        public DbSet<Model.Service> Services { get; set; }

        // Veritabanında randevularla ilgili tabloya erişimi sağlar.
        public DbSet<Model.Appointment> Appointments { get; set; }
    }
}

