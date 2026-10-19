using Xunit;
using SistemaGimnasio.Modelos;


namespace SistemaGimnasio.tests
{
    public class UsuarioTest 
    {
        [Fact]          //los metodos a continacion son pruebas

        public void AsignarRutina_DebeAsignarCorrectmente()
        {
            //Arrange  todo lo que necesito para reproducir el acto 

            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("Yopuedo", 120);

            //act       

            usuario.AsignarRutina(rutina);

            //assert        que tengo que complir 

            Assert.Equal("Yopuedo", usuario.RutinaAsignada.Nombre);
        
        }
    
    
    }

}