using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarEFCore.Entities
{
    [Table(name:"Students", Schema = "dbo")]
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(100)")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Student Age")]
        public int StudentAge { get; set; }

        public override string ToString()
        {
            return $"{nameof(StudentId)} : {StudentId}, {nameof(StudentName)} : {StudentName}, {nameof(StudentAge)} : {StudentAge}";

        }
    }
}
