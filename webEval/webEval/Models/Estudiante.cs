using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public enum Typestudent
    {
        Female,
        Male
    }
    public class Estudiante
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public Typestudent Sex { get; set; }
        [Required]
        public int Birthdate { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    } 
}