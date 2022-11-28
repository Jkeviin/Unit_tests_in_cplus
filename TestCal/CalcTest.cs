using Calcsns;

namespace TestCal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float numero = 1500;

            Calculadora c1 = new Calculadora();
            float iva = c1.obtenerIva(numero);
            float reserva = c1.obtenerReserva(numero);
            float total = c1.totalPagar(numero);

            Assert.AreEqual(294.5, iva);
            Assert.AreEqual(139.5, reserva);
            Assert.AreEqual(1984, total);
        }

    }
}