using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarEFCore.Entities
{
    [Table(name:"Teachers", Schema = "dbo")]
    public class Teachers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Teacher Id")]
        public int TeacherId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(100)")]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        public override string ToString()
        {
            return $"{nameof(TeacherId)} : {TeacherId}, {nameof(TeacherName)} : {TeacherName}";
        }
    }
}
