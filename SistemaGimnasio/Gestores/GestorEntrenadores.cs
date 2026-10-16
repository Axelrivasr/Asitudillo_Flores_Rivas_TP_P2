using SistemaGimnasio.Modelos;


namespace SistemaGimnasio.Gestores
{
    public class GestorEntrenadores
    {
        private List<Entrenador> entrenadores;

        public GestorEntrenadores()
        {

            entrenadores = new List<Entrenador>();
        }

        public void RegistarEntrenadores(string nombre, string especialidad) 
        
        {

            entrenadores.Add(new Entrenador(nombre, especialidad));
        }

        public Entrenador BuscarRutina(string nombre) { 
        
            return entrenadores.FirstOrDefault(r => r.Nombre == nombre);
        }
    }
}
