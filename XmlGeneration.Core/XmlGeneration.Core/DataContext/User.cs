namespace XmlGeneration.Core.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }

        [Key]
        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(500)]
        public string UserEmailAddress { get; set; }

        [StringLength(500)]
        public string PasswordSalt { get; set; }

        [Required]
        [StringLength(12)]
        public string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        [StringLength(12)]
        public string UserType { get; set; }
    }
}
