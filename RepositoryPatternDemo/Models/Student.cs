using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternDemo.Models
{
    [Table("Student")]
    public class Student
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Percentage { get; set; }

        [Required]
        public string? City { get; set; }

    }
}
