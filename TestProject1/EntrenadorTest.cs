using Xunit;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasios.Text
{
    public class EntrenadorTest
    {
        [Fact]
        public void AsignarUsuario_DebeAgregatUsuarioALista()
        {

            //arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var usuario2 = new Usuario("sebastian", 20, "Aumentar masa muscular");
            var entrenador = new Entrenador("pepe", "licuados proteicos");

            //act
            entrenador.AsignarUSuario(usuario);
            entrenador.AsignarUSuario(usuario2);

            //assert
            Assert.NotEmpty(entrenador.ObtenerUsuariosignado());
            Assert.Contains(usuario2, entrenador.ObtenerUsuariosignado());


        }
    }
}
