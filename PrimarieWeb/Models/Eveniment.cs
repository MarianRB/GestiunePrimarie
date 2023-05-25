namespace PrimarieWeb.Models
{
    public class Eveniment
    {
        public int EvenimentId { get; set; }
        public String? numeEveniment { get; set; }

        public string? descriere { get; set; }

        public DateTime? dataEveniment { get; set; }

        public int CetateanId { get; set; }
        public Cetatean? Cetatean { get; set; }
        //public List<User> ListaUser = new List<User>();
    }
}