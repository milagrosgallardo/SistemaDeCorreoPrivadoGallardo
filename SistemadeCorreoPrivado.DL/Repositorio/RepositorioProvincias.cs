using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL.Repositorio
{
    public class RepositorioProvincias : IRepositorioProvincias
    {
        private readonly SqlConnection _conexion;
        public RepositorioProvincias(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public List<Provincia> GetProvincias()
        {
            List<Provincia> lista = new List<Provincia>();
            try
            {
                string cadenaComando = "select ProvinciaId,NombreProvincia from Provincias";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincia = ConstruirProvincia(reader);
                    lista.Add(provincia);
                }
                reader.Close();
                return lista;
            }
            catch (Exception exeption)
            {

                throw new Exception("Error al intentar leer las Provincias");
            }
        }

        private Provincia ConstruirProvincia(SqlDataReader reader)
        {
            return new Provincia
            {
                ProvinciaId = reader.GetInt32(0),
                NombreProvincia = reader.GetString(1)
            };
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Provincia provincia)
        {
            throw new NotImplementedException();
        }
    }
}
