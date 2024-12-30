using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.Maliyet;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.Maliyet;

namespace ERP.Models.Veri.IsMerkez
{
    //iş merkezleri
    public class BSMGRNNMWCMHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string WCMDOCNUM { get; set; } //İş Merkezi NO PK

        [MaxLength(4)]
        public required string WCMDOCTYPE { get; set; } //İŞ MERKEZİ TİPİ FK
        public required DateTime WCMDOCFROM { get; set; }
        public required DateTime WCMDOCUNTIL { get; set; }
        public required string MAINWCMDOCTYPE { get; set; } //Ana İş Merkezi Tipi
        public required string MAINWCMDOCNUM { get; set; }

        [MaxLength(4)]
        public required string CCMDOCTYPE { get; set; }
        public required string CCMDOCNUM { get; set; }
        public double? WORKTIME { get; set; }
        public int? ISDELETED { get; set; }
        public int? ISPASSIVE { get; set; }
        public required string WCMSTEXT { get; set; } //İş Merkezi Kısa Açıklaması
        public required string WCMLTWXT { get; set; }
        public required string LANCODE { get; set; }
        public required string OPRDOCTYPE { get; set; }

        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMWCM001? DOCTYPE { get; set; }
        public virtual BSMGRNNMCCM001? FCCMDOCTYPE { get; set; }
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
    }
}
