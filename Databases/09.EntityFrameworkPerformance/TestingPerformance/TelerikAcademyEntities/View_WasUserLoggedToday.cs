namespace TestingPerformance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_WasUserLoggedToday
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Pasdbord { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(80)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime LastLogin { get; set; }
    }
}
