namespace CalendarFormula1.Models
{
    public class Piloti_Cursa
    {
        public int CursaId { get; set; } 

        public Cursa Cursa { get; set; }

        public int PilotiId { get; set; }

        public Piloti Piloti { get; set; }
    }
}
