namespace masterpol.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialType")]
    public partial class MaterialType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMaterialType { get; set; }

        [Required]
        [StringLength(150)]
        public string MaterialTypeName { get; set; }

        public double DefectivaMaterialPercentage { get; set; }
    }
}
