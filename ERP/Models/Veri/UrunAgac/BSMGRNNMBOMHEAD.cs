using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Maliyet;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.Malzeme;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Kontrol.MalzemeBilgi;

namespace ERP.Models.Veri.UrunAgac
{
    public class BSMGRNNMBOMHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(25)]
        public required string BOMDOCNUM { get; set; } //ürün ağacı kodu

        [MaxLength(4)]
        public required string BOMDOCTYPE { get; set; } //ürün ağacı tipi fk
        public required DateTime BOMDOCFROM { get; set; }
        public required DateTime BOMDOCUNTIL { get; set; }

        [MaxLength(4)]
        public required string MATDOCTYPE { get; set; }
        public required string MATDOCNUM { get; set; }
        public required double QUANTITY { get; set; }
        public required int CONTENTNUM { get; set; } // İçerik Numarası
        public required string COMPONENT { get; set; } //Bileşen Kodu
        public int? ISDELETED { get; set; }
        public int? ISPASSIVE { get; set; }
        public string? DRAWNUM { get; set; } // Çizim Numarası

        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMBOM001? DOCTYPE { get; set; }
        public virtual BSMGRNNMMAT001? FMATDOCTYPE { get; set; }

    }
}
