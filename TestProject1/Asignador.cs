using Xunit;
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasios.Text
{
    public class AsignadorRutinaTest
    {
        [Fact]

        public void AsignarRutinaUsuario_DebeAsignarCorrectamente() 
        {

            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("YoPuedo", 120);
            var asignador = new AsignadorRutinas();

            asignador.AsignarRutinaAUsuario(usuario, rutina);

            Assert.Equal(rutina, usuario.RutinaAsignada);

        }


        [Fact]

        public void AsignarUsuarioAEntrenador_DebeIncluirUSuario()
        {

            //arenge
            var usuario = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("pepe", "licuados proteicos");
            var asignador = new AsignadorRutinas();

            //act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //assert

            Assert.Contains(usuario, entrenador.ObtenerUsuariosignado());


        }


    }
}
