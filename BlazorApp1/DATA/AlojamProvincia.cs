using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.DATA
{
    [Table("TBAlojam")]
    public class AlojamProvincia
    {
        [Key]
        [Column("IdAlojamiento")]  
        public int IdAlojamiento { get; set; }

        [Column("AloNombre")] 
        public string AloNombre { get; set; }

        [Column("THCod")]
        public int THCod { get; set; }
    }
}
