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
            throw new NotImplementedException();
        }

        public bool Existe(Zona zona)
        {
            throw new NotImplementedException();
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
            catch (Exception ex)
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
            throw new NotImplementedException();
        }
    }
}
