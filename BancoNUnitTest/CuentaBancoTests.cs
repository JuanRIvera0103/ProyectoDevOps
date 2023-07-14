using NUnit.Framework;
using ProyectoDevOps;

namespace BancoNUnitTest
{
    public class CuentaBancoTests
    {
        [Test]
        public void Agregar_Fondos_Actualizar_Balance()
        {
            //Arrange
            var cuenta = new CuentaBanco(1_000);

            //Act
            cuenta.Agregar(500);

            //Assert
            Assert.AreEqual(1_500, cuenta.balance);
        }

        [Test]
        public void Retirar_Fondos_Actualizar_Balance()
        {
            //Arrange
            var cuenta = new CuentaBanco(1_600);

            //Act
            cuenta.Retirar(1100);

            //Assert
            Assert.AreEqual(500, cuenta.balance);
        }

        [Test]
        public void Transferir_Fondos_Actualizar_Ambas_Cuentas()
        {
            //Arrange
            var cuenta = new CuentaBanco(1_000);
            var otraCuenta = new CuentaBanco();

            //Act
            cuenta.TransferirFondos(otraCuenta, 500);

            //Assert
            Assert.AreEqual(500, cuenta.balance);
            Assert.AreEqual(500, otraCuenta.balance);
        }

        [Test]
        public void Metodo_Pruebas()
        {
            //Arrange
            var cuenta = new CuentaBanco(2_000);
            var otraCuenta = new CuentaBanco();

            //Act
            cuenta.TransferirFondos(otraCuenta, 500);

           
        }
    }
}