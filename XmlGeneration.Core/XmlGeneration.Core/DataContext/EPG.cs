namespace XmlGeneration.Core.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EPGDataModel : DbContext
    {
        public EPGDataModel()
            : base("name=EPGDataModel")
        {
        }

        public virtual DbSet<SourceURL> SourceURLs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<XmlImport> XmlImports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
