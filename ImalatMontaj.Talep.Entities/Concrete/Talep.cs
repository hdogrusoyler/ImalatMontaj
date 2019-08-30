using ImalatMontaj.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImalatMontaj.Talep.Entities.Concrete
{
    public class Talep : IEntity
    {
        [Display(Name = "Talep Numarası")]
        public int Id { get; set; }
        [Display(Name = "Talep Tipi: Talep/Montaj")]
        public char Tip { get; set; }
        [Display(Name = "Ürün Tanımı")]
        public string UrunTanimi { get; set; }
        [Display(Name = "Talep Edilen Yer")]
        public string TalepEdilenYer { get; set; }

        [Display(Name = "Talep Edenin Adı Soyadı")]
        public string TalepEdenAdSoyad { get; set; }
        [Display(Name = "Talep Edilen Tarih")]
        public DateTime? TalepEdenTarihi { get; set; }
        [Display(Name = "Talep Edenin Departmanı")]
        public string TalepEdenDepartman { get; set; }

        [Display(Name = "Talebi Onaylayanın Adı Soyadı")]
        public string TalepOnayAdSoyad { get; set; }
        [Display(Name = "Talep Onaylama Tarihi")]
        public DateTime? TalepOnayTarihi { get; set; }

        [Display(Name = "Talebi Yapanın Adı Soyadı")]
        public string TalepYapanAdSoyad { get; set; }
        [Display(Name = "Talebi Yapanın Talep Tarihi")]
        public DateTime? TalepYapanTalepTarihi { get; set; }
        [Display(Name = "Talebi Yapan Departman")]
        public string TalepYapanDepartman { get; set; }

        [Display(Name = "Talebi Kontrol Edenin Adı Soyadı")]
        public string TalepKontrolAdSoyad { get; set; }
        [Display(Name = "Talebin Kontrol Tarihi")]
        public DateTime? TalepKontrolTarihi { get; set; }
        [Display(Name = "Talebi Kontrol Eden Departman")]
        public string TalepKontrolDepartman { get; set; }

        public List<Foto> Fotos { get; set; }
    }
}