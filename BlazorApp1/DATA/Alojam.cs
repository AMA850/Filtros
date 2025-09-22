using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.DATA
{
    [Table("TBAlojam")]
    public class Alojam
    {
        [Key]
        [Column("IdAlojamiento")]  
        public int IdAlojamiento { get; set; }

        [Column("AloNombre")] 
        public string AloNombre { get; set; }
        [Column("THCod")]
        public int THCod { get; set; }

        [Column("ComCod")]
        public int ComCod { get; set; }

        [Column("DogFriendly")]
        public bool dog { get; set; };
    }
}
