namespace FinalSuperHeroes.Models
{
    public class Enfermeria
    {
        private static readonly Enfermeria _instancia = new Enfermeria();
        private const int MaxAtenciones = 5;
        private int _atencionesDisp = MaxAtenciones;
        private Enfermeria() { }
        public static Enfermeria ObtenerInstancia() => _instancia;
        public bool VisitarEnfermeria(ref int saludActual, int cantidadVisitas)
        {
            if (_atencionesDisp <= 0)
            {
                return false;
            }

            for (int i = 0; i < cantidadVisitas; i++)
            {
                if (_atencionesDisp > 0 && saludActual < 5)
                {
                    saludActual++;
                    _atencionesDisp--;
                }
            }

            return true;
        }
        public int GetAtencionesRestantes() => _atencionesDisp;
    }
}