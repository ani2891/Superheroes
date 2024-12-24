using Superheroes.Interfaces;

namespace Superheroes.Models
{
    public class Warrior : ISuperheroe
    {
        public Warrior(string nombre)
        {
            Nombre = nombre;
            Tipo = "warrior";
            Salud = 5;
            Fuerza = 8;
            PoderEspecial = "Super fuerza!";
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