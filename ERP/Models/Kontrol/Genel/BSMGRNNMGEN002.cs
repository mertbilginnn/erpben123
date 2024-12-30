using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //diller
    public class BSMGRNNMGEN002
    {
        [Key]
        public required string LANCODE { get; set; }
        public required string LANTEXT { get; set; }

        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } 

    }
}
