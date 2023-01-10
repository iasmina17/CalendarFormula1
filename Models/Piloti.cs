using System.ComponentModel.DataAnnotations;

namespace CalendarFormula1.Models
{
    public class Piloti
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string NumePilot { get; set; }

        public int NumarPilot { get; set; }

        public string Echipa { get; set; }
    }
}
