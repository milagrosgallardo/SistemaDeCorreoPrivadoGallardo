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
            throw new NotImplementedException();
        }

        public bool Existe(Tarea tarea)
        {
            throw new NotImplementedException();
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
            catch (Exception ex)
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
            throw new NotImplementedException();
        }
    }
}
