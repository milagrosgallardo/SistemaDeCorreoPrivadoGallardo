using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL.Repositorio
{
    public class RepositorioZonas : IRepositorioZonas
    {   //conexion de datos
        private readonly SqlConnection _conexion;

        public RepositorioZonas(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Zonas WHERE ZonaId=@id";
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

        public bool Existe(Zona zona)
        {
            if (zona.ZonaId == 0)
            {
                string cadenaComando = "select ZonaId,NombreZona from Zonas where NombreZona=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", zona.NombreZona);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando = "select ZonaId,NombreZona from Zonas where NombreZona=@nom and ZonaId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", zona.NombreZona);
                comando.Parameters.AddWithValue("@id", zona.ZonaId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public Zona GetZonaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Zona> GetZonas()
        {
            List<Zona> lista = new List<Zona>();//ver
            try
            {    // cadena a usar 
                string cadenaComando = "select ZonaId,NombreZona  from Zonas";
                //comando a ejecutar
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();

                //mientras tenga que leer
                while (reader.Read())
                {               //recibe el registro que leo y devuelve una zona
                    Zona zona = ConstruirZona(reader);
                    lista.Add(zona);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las Zonas");
            }
        }

        private Zona ConstruirZona(SqlDataReader reader)
        {
            return new Zona
            {
                ZonaId = reader.GetInt32(0),
                NombreZona = reader.GetString(1)
            };
        }

        public void Guardar(Zona zona)
        {
            if (zona.ZonaId == 0)
            {
               
                try
                {  
                    string cadenaComando = "insert into Zonas values(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", zona.NombreZona);

                    comando.ExecuteNonQuery();
                    cadenaComando = "select @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    zona.ZonaId = (int)(decimal)comando.ExecuteScalar();
                    

                }
                catch (Exception)
                {
                    throw new Exception("Erro al intentar guardar un registro");
                }

            }
            else
            {
                
                try
                {
                    string cadenaComando = "UPDATE Zonas SET NombreZona=@nombre WHERE ZonaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", zona.NombreZona);
                    comando.Parameters.AddWithValue("@id", zona.ZonaId);
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
