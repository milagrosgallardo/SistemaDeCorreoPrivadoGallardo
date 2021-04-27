using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL.Repositorio
{
    public class RepositorioModalidades : IRepositorioModalidad
    {
        private readonly SqlConnection _conexion;

        public RepositorioModalidades(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Modalidades WHERE ModalidadId=@id";
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

        public bool Existe(Modalidad modalidad)
        {
            if (modalidad.ModalidadId == 0)
            {
                string cadenaComando = "select ModalidadId,NombreModalidad from Modalidades where NombreModalidad=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", modalidad.NombreModalidad);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando = "select ModalidadId,NombreModalidad from Modalidades where NombreModalidad=@nom and ModalidadId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", modalidad.NombreModalidad);
                comando.Parameters.AddWithValue("@id", modalidad.ModalidadId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public List<Modalidad> GetModalidades()
        {
            List<Modalidad> lista = new List<Modalidad>();
            try
            {
                string cadenaComando = "select ModalidadId,NombreModalidad from Modalidades";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Modalidad modalidad = ConstruirModalidad(reader);
                    lista.Add(modalidad);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las Modalidades");
            }
        }

        private Modalidad ConstruirModalidad(SqlDataReader reader)
        {
            return new Modalidad
            {
                ModalidadId = reader.GetInt32(0),
                NombreModalidad = reader.GetString(1)
            };
        }

        public Modalidad GetModalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Modalidad modalidad)
        {
            if (modalidad.ModalidadId == 0)
            {

                try
                {
                    string cadenaComando = "insert into Modalidades values(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", modalidad.NombreModalidad);

                    comando.ExecuteNonQuery();
                    cadenaComando = "select @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    modalidad.ModalidadId = (int)(decimal)comando.ExecuteScalar();


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
                    string cadenaComando = "UPDATE Modalidades SET NombreModalidad=@nom WHERE ModalidadId =@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nom", modalidad.NombreModalidad);
                    comando.Parameters.AddWithValue("@id", modalidad.ModalidadId);
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
