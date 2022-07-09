using Microsoft.AspNetCore.Mvc;
using Moq;
using n00033054app.Controllers;
using n00033054app.Models;
using n00033054app.Repositorios;

namespace CuentaTest
{
    public class Tests
    {

        [Test]
        public void cargarListaCuentas()
        {
            var cuentaMock = new Mock<ICuentaRepositorio>();
            var Cuentas = new List<Cuenta>();
            cuentaMock.Setup(o => o.listaCuentas()).Returns(Cuentas);

            var cuentaController = new CuentaController(cuentaMock.Object);

            var index = cuentaController.Index();
            Assert.IsInstanceOf<ViewResult>(index);
        }

        [Test]
        public void CreateCuentaCorrect()
        {
            var cuenta = new Cuenta();
            cuenta.nombre = "Cuenta test";
            cuenta.categoria = "propia";
            cuenta.saldoini = 100;
            cuenta.moneda = 'S';
            var cuentaMock = new Mock<ICuentaRepositorio>();
            var Cuentas = new List<Cuenta>();

            var cuentaController = new CuentaController(cuentaMock.Object);
            var index = cuentaController.Create(cuenta);
            Assert.IsInstanceOf<RedirectToActionResult>(index);
        }
        [Test]
        public void CreateCuentaIncorrect()
        {
            
            var cuentaMock = new Mock<ICuentaRepositorio>();
            var Cuentas = new List<Cuenta>();

            var cuentaController = new CuentaController(cuentaMock.Object);
            var index = cuentaController.Create();
            Assert.IsInstanceOf<ViewResult>(index);
        }
    }
}