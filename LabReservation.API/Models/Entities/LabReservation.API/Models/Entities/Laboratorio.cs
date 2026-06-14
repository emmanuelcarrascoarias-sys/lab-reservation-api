namespace LabReservation.API.Models.Entities
{
    public class Laboratorio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Edificio { get; set; } = string.Empty;
        public int NumeroSalon { get; set; }
        public int Capacidad { get; set; }
        public ICollection<Computadora> Computadoras { get; set; } = new List<Computadora>();
    }
}
