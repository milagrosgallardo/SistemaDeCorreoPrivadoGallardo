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
            throw new NotImplementedException();
        }

        public bool Existe(Modalidad modalidad)
        {
            throw new NotImplementedException();
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
            catch (Exception ex)
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
            throw new NotImplementedException();
        }
    }
}
