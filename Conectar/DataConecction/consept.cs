namespace DataConecction
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("consept")]
    public partial class consept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroIdentificacion { get; set; }

        public int? TipoDocumento { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }
    }
}
