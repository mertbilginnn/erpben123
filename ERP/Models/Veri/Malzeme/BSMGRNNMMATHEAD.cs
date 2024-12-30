
using ERP.Models.Kontrol.Genel;
using ERP.Models.Kontrol.MalzemeBilgi;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Veri.UrunAgac;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Veri.Malzeme
{
    //malzeme temel bilgileri
    public class BSMGRNNMMATHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string MATDOCNUM { get; set; } //malzeme kodu

        [MaxLength(4)]
        public required string MATDOCTYPE { get; set; } //malzeme tipi
        public required DateTime MATDOCFROM { get; set; } //geçerlilik
        public required DateTime MATDOCUNTIL { get; set; } //geçer bitiş
        public required int SUPPLYTYPE { get; set; } //tedarik tipi
        public required string STUNIT { get; set; } //malzeme stok birimi gen5den
        public double? NETWEIGHT { get; set; } //net agırlık
        public string? NWUNIT { get; set; } //net agırlık birimi
        public double? BRUTWEIGHT { get; set; }  //brüt ağırlık
        public string? BWUNIT { get; set; } //brut agırlık birimi
        public int? ISBOM { get; set; } //ürün agacı var mı

        [MaxLength(4)]
        public  string? BOMDOCTYPE { get; set; }
        public  string? BOMDOCNUM { get; set; }
        public int? ISROUTE { get; set; } //rota var mı

        [MaxLength(4)]
        public  string? ROTDOCTYPE { get; set; } //rota tipi
        public string? ROTDOCNUM { get; set; }  //rota numarası
        public int? ISDELETED { get; set; }
        public int? ISPASSIVE { get; set; }
        public required string LANCODE { get; set; } //dil kodu
        public required string MATSTEXT { get; set; } //malzeme kısa açıklama
        public   string MATLTEXT { get; set; } //malzeme uzun açıklama

        //nav properties

        public virtual BSMGRNNMGEN005? FSTUNIT { get; set; } // Stok Birimi
        public virtual BSMGRNNMGEN005? FNWUNIT { get; set; } // Net Ağırlık Birimi
        public virtual BSMGRNNMGEN005? FBWUNIT { get; set; } // Brüt Ağırlık Birimi
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } 
        public virtual BSMGRNNMMAT001? FMATDOCTYPE { get; set; } //malzeme tipi mat1den
        public virtual BSMGRNNMBOM001? FBOMDOCTYPE { get; set; } //ürün ağaç tipi bom1den
        public virtual BSMGRNNMROT001? FROTDOCTYPE { get; set; } //rota tipi rot1den
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }


    }
}
