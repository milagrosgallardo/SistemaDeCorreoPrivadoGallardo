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
            try
            {
                string cadenaComando = "DELETE FROM Provincias WHERE ProvinciaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registro con datos asociados... Baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            if (provincia.ProvinciaId == 0)
            {// nueva provincia
                string cadenaComando = "select ProvinciaId,NombreProvincia from Provincias where NombreProvincia=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", provincia.NombreProvincia);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
                //HasRows devuelve un bool 
            }
            else
            {// edito provincia
                // se fija si ya existe ese nombre y si tiene id diferente lo rechaza 
                string cadenaComando = "select ProvinciaId,NombreProvincia from Provincias where NombreProvincia=@nom and ProvinciaId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", provincia.NombreProvincia);
                comando.Parameters.AddWithValue("@id", provincia.ProvinciaId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public List<Provincia> GetProvincias()
        {  // instancio la lista 
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
            catch (Exception)
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
            if (provincia.ProvinciaId == 0)
            {
                // nuevo registro
                try
                { // para agregar hago un insert le paso el nombre 
                    string cadenaComando = "insert into Provincias values(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);

                    comando.ExecuteNonQuery();
                    cadenaComando = "select @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    provincia.ProvinciaId = (int)(decimal)comando.ExecuteScalar();
                    // una ves agregado mr traigo el id 

                }
                catch (Exception)
                {
                    throw new Exception("Erro al intentar guardar un registro");
                }

            }
            else
            {
                //edicion
                try
                {
                    string cadenaComando = "UPDATE Provincias SET NombreProvincia=@nombre WHERE ProvinciaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                    comando.Parameters.AddWithValue("@id", provincia.ProvinciaId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw new Exception("Erro al intentar Modificar un registro");
                }

            }
        }
    }
}
