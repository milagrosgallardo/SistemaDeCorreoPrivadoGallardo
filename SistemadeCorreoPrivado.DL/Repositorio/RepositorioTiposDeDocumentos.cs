using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemadeCorreoPrivado.DL.Repositorio
{
    public class RepositorioTiposDeDocumentos : IRepositorioTiposDeDocumentos
    {
        private readonly SqlConnection _conexion;

        public RepositorioTiposDeDocumentos(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TiposDeDocumento tiposDeDocumento)
        {
            throw new NotImplementedException();
        }

        public List<TiposDeDocumento> GetTiposDeDocumento()
        {
            List<TiposDeDocumento> lista = new List<TiposDeDocumento>();
            try
            {
                string cadenaComando = "select TipoDeDocumentoId,NombreDocumento from TiposdeDocumento";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TiposDeDocumento tiposDeDocumento = ConstruirTiposDeDocumento(reader);
                    lista.Add(tiposDeDocumento);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar leer los tipos de documentos");
            }
        }

        private TiposDeDocumento ConstruirTiposDeDocumento(SqlDataReader reader)
        {
            return new TiposDeDocumento
            {
                TipoDeDocumentoId = reader.GetInt32(0),
                NombreDocumento = reader.GetString(1)
            };
        }

        public TiposDeDocumento GetTiposDeDocumentoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TiposDeDocumento tiposDeDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
