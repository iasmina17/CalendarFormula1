using CalendarFormula1.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace CalendarFormula1.Models
{
    public class Cursa
    {
        [Key]
        public int Id { get; set; }
        public string NumeCursa { get; set; }
        public string Descriere { get; set; }

        public string ImageURL { get; set; }

        public DateTime DataCursa { get; set; }

        public CategorieCircuit CategorieCircuit { get; set; }
    }
}
