using Superheroes.Interfaces;

namespace Superheroes.Models
{
    public class Archer : ISuperheroe
    {
        public Archer(string nombre)
        {
            Nombre = nombre;
            Tipo = "archer";
            Salud = 5;
            Fuerza = 7;
            PoderEspecial = "flechas élficas";
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