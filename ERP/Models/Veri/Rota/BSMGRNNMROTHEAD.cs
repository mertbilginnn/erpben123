using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.UrunAgac;
using ERP.Models.Veri.IsMerkez;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.MalzemeBilgi;
using ERP.Models.Kontrol.UrunAgac;

namespace ERP.Models.Veri.Rota
{
    //rota başlık bilgileri
    public class BSMGRNNMROTHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string ROTDOCNUM { get; set; } //rota numarası
        [MaxLength(4)]
        public required string ROTDOCTYPE { get; set; } //rota tipi
        public required DateTime ROTDOCFROM { get; set; } //geçerlilik başlangıç
        public required DateTime ROTDOCUNTIL { get; set; }

        [MaxLength(4)]
        public required string MATDOCTYPE { get; set; } //malzeme tipi
        public required string MATDOCNUM { get; set; } //malzeme kodu
        public int OPRNUM { get; set; } //operasyon numarası
        [MaxLength(4)]
        public required string WCMDOCTYPE { get; set; } //iş merkezi tipi
        public required string WCMDOCNUM { get; set; } //iş merkezi numarası
        public required double SETUPTIME { get; set; }
        public required double MACHINETIME { get; set; }
        public required double LABOURTIME { get; set; }

        [MaxLength(4)]
        public required string BOMDOCTYPE { get; set; } //ürün ağacı tip
        public required string BOMDOCNUM { get; set; } //ürün ağacı kod
        public string DRAWNUM { get; set; } //çizim no
        public required int CONTENTNUM { get; set; } //içerik no
        public required string COMPONENT { get; set; } //bileşen kodu
        public required double QUANTITY { get; set; } 
        public int? ISDELETED { get; set; }
        public int? ISPASSIVE { get; set; }

        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMROT001? FROTDOCTYPE { get; set; }
        public virtual BSMGRNNMMAT001? FMATDOCTYPE { get; set; }
        public virtual BSMGRNNMWCM001? FWCMDOCTYPE { get; set; }
        public virtual BSMGRNNMBOM001? FBOMDOCTYPE { get; set; } 

    }
}
