namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class StudentInfo
    {
        [Column("E mail")]
        public string Email { get; set; }

        [Column("Address")]
        public string Address { get; set; }
    }
}
