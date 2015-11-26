namespace XmlGeneration.Core.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XmlImport")]
    public partial class XmlImport
    {
        [Key]
        public long Srno { get; set; }

        [StringLength(500)]
        public string XmlFileName { get; set; }

        public DateTime ImportDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EpgStartDt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EpgEndDt { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(500)]
        public string Url2 { get; set; }

        [StringLength(250)]
        public string SourceUrl { get; set; }
    }
}
