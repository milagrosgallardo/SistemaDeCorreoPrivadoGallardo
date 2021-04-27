using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL.Repositorio
{
    public class RepositorioTareas : IRepositorioTareas
    {
        private readonly SqlConnection _conexion;

        public RepositorioTareas(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Tareas WHERE TareaId=@id";
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

        public bool Existe(Tarea tarea)
        {
            if (tarea.TareaId == 0)
            {
                string cadenaComando = "select TareaId,NombreTarea from Tareas where NombreTarea=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", tarea.NombreTarea);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando = "select TareaId,NombreTarea from Tareas where NombreTarea=@nom and TareaId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", tarea.NombreTarea);
                comando.Parameters.AddWithValue("@id", tarea.TareaId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public List<Tarea> GetTareas()
        {
            List<Tarea> lista = new List<Tarea>();
            try
            {
                string cadenaComando = "select TareaId,NombreTarea from Tareas";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tarea tarea = ConstruirTarea(reader);
                    lista.Add(tarea);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las tareas");
            }
        }

        private Tarea ConstruirTarea(SqlDataReader reader)
        {
            return new Tarea
            {
                TareaId = reader.GetInt32(0),
                NombreTarea = reader.GetString(1)
            };
        }

        public Tarea GetTareaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Tarea tarea)
        {
            if (tarea.TareaId == 0)
            {

                try
                {
                    string cadenaComando = "insert into Tareas values(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", tarea.NombreTarea);

                    comando.ExecuteNonQuery();
                    cadenaComando = "select @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    tarea.TareaId = (int)(decimal)comando.ExecuteScalar();


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
                    string cadenaComando = "UPDATE Tareas SET NombreTarea=@nombre WHERE TareaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", tarea.NombreTarea);
                    comando.Parameters.AddWithValue("@id", tarea.TareaId);
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
