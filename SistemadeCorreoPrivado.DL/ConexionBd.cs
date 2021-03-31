﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL
{
    public class ConexionBd
    {
        private readonly SqlConnection _cnSqlConnection;
        public ConexionBd()
        {
            var cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            _cnSqlConnection = new SqlConnection(cadenaDeConexion);
        }
        public SqlConnection AbrirConexion()
        {
            if (_cnSqlConnection.State == ConnectionState.Closed)
            {
                _cnSqlConnection.Open();
            }
            return _cnSqlConnection;
        }
        public void CerrarConexion()
        {
            if (_cnSqlConnection.State == ConnectionState.Open)
            {
                _cnSqlConnection.Close();
            }
        }
    }
}
