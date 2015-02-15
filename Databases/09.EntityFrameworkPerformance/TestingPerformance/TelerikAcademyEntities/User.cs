namespace TestingPerformance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Pasdbord { get; set; }

        [Required]
        [StringLength(80)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastLogin { get; set; }

        public int GroupId { get; set; }
    }
}
