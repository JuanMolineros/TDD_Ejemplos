using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Banco;

namespace TDD_Banco_Pruebas
{
    [TestClass]
    public class Test_CuentaBancaria
    {
        [TestMethod]
        public void CreacionCuenta_SaldoCero()
        {
            CuentaBancaria CtaBancaria = new CuentaBancaria();
            Assert.AreEqual(0, CtaBancaria.getSaldo());
        }

        [TestMethod]
        public void AlIngresar100enCuentaVaciaelSaldoes100()
        {
            CuentaBancaria CtaBancaria = new CuentaBancaria();
            CtaBancaria.Consignacion(3000);
            Assert.AreEqual(3000, CtaBancaria.getSaldo());
        }

    }
    
}
