using Superheroes.Interfaces;

namespace Superheroes.Models
{
    public class Wizard : ISuperheroe
    {
        public Wizard(string nombre)
        {
            Nombre = nombre;
            Tipo = "wizard";
            Salud = 5;
            Fuerza = 10;
            PoderEspecial = "You shall not pass!";
        }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public string Atacar()
        {
            return $"{Nombre} realizó un ataque";
        }
        public string Defender()
        {
            return $"{Nombre} se defendió efectivamente";
        }
    }
}