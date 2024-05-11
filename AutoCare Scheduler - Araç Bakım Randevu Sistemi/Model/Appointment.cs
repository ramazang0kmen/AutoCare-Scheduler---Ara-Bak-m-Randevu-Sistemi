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

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model
{
    // Randevu sınıfı, bir müşterinin alacağı hizmet için oluşturulan randevuyu temsil eder.
    public class Appointment
    {
        // Randevu ID'si.
        public int Id { get; set; }

        // Müşteri ID'si. Bu randevunun hangi müşteriye ait olduğunu belirtir.
        public int CustomerId { get; set; }

        // Hizmet ID'si. Bu randevunun hangi hizmet için olduğunu belirtir.
        public int ServiceId { get; set; }

        // Personel ID'si. Bu randevuyu gerçekleştirecek personelin ID'sini belirtir.
        public int PersonnelId { get; set; }

        // İşlem ID'si. Bu randevuda yapılacak işlemi belirten bir ID'dir.
        public int OperationId { get; set; }

        // Randevu tarihi ve saati.
        public DateTime Date { get; set; }

        // Toplam fiyat. Bu randevu için belirlenen toplam fiyatı belirtir.
        public Decimal TotalPrice { get; set; }

        // Açıklama. Bu randevuyla ilgili herhangi bir ek açıklama.
        public string Description { get; set; }
    }
}
