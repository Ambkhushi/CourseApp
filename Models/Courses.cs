using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationExercise.Models
{
    [Table("Courses")]
    public class Courses
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public double CFee { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
    }
}

