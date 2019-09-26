using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public enum TypeMateria
    {
        Matematicas,
        Fisica,
        Quimica
    }
    public enum TypeEstado
    {
        Aprobado,
        Aplazado
    }
    public class Nota
    {
        [Key]
        [Required]
        public TypeMateria Materia { get; set; }
        [Required]
        public int Notas { get; set; }
        [Required]
        public TypeEstado Estado { get; set; }
        [Required]
        public string Name { get; set; }

    }
}