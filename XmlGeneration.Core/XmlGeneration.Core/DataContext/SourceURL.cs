namespace XmlGeneration.Core.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SourceURL")]
    public partial class SourceURL
    {
        [Key]
        public long Srno { get; set; }

        [Required]
        [StringLength(500)]
        public string URL { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        public DateTime EntryDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EntryId { get; set; }

        [StringLength(50)]
        public string EntryIP { get; set; }

        public bool IsActive { get; set; }
    }
}
