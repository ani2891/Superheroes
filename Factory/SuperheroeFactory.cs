using Superheroes.Interfaces;
using Superheroes.Models;

namespace Superheroes.Factory
{
    public static class SuperHeroFactory
    {
        public static ISuperheroe CrearSuperHeroe(string nombre, string tipo)
        {
            switch (tipo.ToLower())
            {
                case "archer":
                    return new Archer(nombre);
                case "wizard":
                    return new Wizard(nombre);
                case "warrior":
                    return new Warrior(nombre);
                default:
                    throw new ArgumentException($"Estás segura de que \"{tipo}\" es correcto? Volvé a probar! Recordá que los tipos son: warrior, wizard y archer.");
            }
        }
    }
}