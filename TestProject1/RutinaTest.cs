using Xunit;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasios.Text
{
    public class RutinaTest
    {

        [Fact]
        public void agregarEjercicio_DebeAregarALista() {

            //arrange
            var rutina = new Rutina("Yopuedo", 120);
            var ejercicio1 = new Ejercicio("Levantar", 15, 5, 90);
            var ejercicio2 = new Ejercicio("Press", 12, 4, 30);


            //act

            rutina.AgregarEjercicios(ejercicio1);
            rutina.AgregarEjercicios(ejercicio2);

            //assert
            Assert.NotEmpty(rutina.ObtenerEjercicios());
            Assert.Equal(rutina.ObtenerEjercicios()[0].Nombre, "Levantar");

        }
    }
}
