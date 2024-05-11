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
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Model.Customer> Customers { get; set; }
        public DbSet<Model.Operation> Operations { get; set; }
        public DbSet<Model.Personnel> Personnels { get; set; }
        public DbSet<Model.Service> Services { get; set; }
        public DbSet<Model.Appointment> Appointments { get; set; }
    }
}
