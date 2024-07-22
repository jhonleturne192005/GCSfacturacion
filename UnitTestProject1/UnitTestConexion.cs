using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaFacturacion.AccesoDatos;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestConexion
    {
        [TestMethod]
        public void TM_Conexion_abierta()
        {
            Conexion con = new Conexion();
            con.AbrirConexion();

            Assert.IsTrue(con.ConexionAbierta());
            con.CerrarConexion();
        }

        [TestMethod]
        public void TM_Conexion_cerrada_sin_iniciar()
        {
            Conexion con = new Conexion();
            Assert.IsFalse(con.ConexionAbierta());
        }

        [TestMethod]
        public void TM_Conexion_cerrada()
        {
            Conexion con = new Conexion();
            con.AbrirConexion();
            con.CerrarConexion();

            Assert.IsFalse(con.ConexionAbierta());
        }
    }
}
