using System.ComponentModel.DataAnnotations;

namespace CalendarFormula1.Models
{
    public class Tara
    {
        [Key]
        public int Id { get; set; }
        public string NumeTara { get; set; }
        public string Oras { get; set; }

        public string PictureURL { get; set; }
    }
}
