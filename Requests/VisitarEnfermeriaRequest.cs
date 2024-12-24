namespace Superheroes.Requests
{
    public class VisitarEnfermeriaRequest
    {
        public string Tipo { get; set; }
        public int SaludActual { get; set; }
        public int CantidadVisitas { get; set; }
    }
}
