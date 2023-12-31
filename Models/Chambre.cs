namespace GestionHotel.Models
{
    
    public class Chambre
    {
        public int Numero { get; set; }
        public string Type { get; set; }
        public int NumeroEtage { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}
