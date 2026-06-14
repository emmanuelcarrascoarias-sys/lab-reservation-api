namespace LabReservation.API.Models.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
