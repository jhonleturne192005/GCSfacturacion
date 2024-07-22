using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaFacturacion.Utencilios;

using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestValidaciones
    {
        [DataTestMethod]
        [DataRow("Password123!")]
        [DataRow("Contra:2023")]
        [DataRow("ContraseniaD2#")]
        public void MT_Contrasenia_valida(string contrasenia)
        {
            Assert.IsTrue(Validaciones.esContraseniaValida(contrasenia));
        }

        [DataTestMethod]
        [DataRow("Password123")]
        [DataRow("Contra2023")]
        [DataRow("ContraseniaD2")]
        [DataRow("!223123124@")]
        public void MT_Contrasenia_no_valida(string contrasenia)
        {
            Assert.IsFalse(Validaciones.esContraseniaValida(contrasenia));
        }

        [DataTestMethod]
        [DataRow("1234569874")]
        [DataRow("2350703385")]
        [DataRow("1705236521")]
        [DataRow("1705236522")]
        [DataRow("1705236523")]
        [DataRow("1725231524")]
        public void MT_Cedula_valida(string cedula)
        {
            Assert.IsTrue(Validaciones.esCedulaValida(cedula));
        }

        [DataTestMethod]
        [DataRow("123456987")]
        [DataRow("23507033865")]
        [DataRow("17052E6521")]
        [DataRow("1@05236522")]
        [DataRow("170Q23652E")]
        [DataRow("17231524")]
        public void MT_Cedula_no_valida(string cedula)
        {
            Assert.IsFalse(Validaciones.esCedulaValida(cedula));
        }
    }
}
