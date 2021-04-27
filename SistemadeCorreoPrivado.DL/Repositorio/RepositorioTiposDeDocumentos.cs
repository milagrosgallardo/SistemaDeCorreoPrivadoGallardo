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
            try
            {
                string cadenaComando = "DELETE FROM TiposdeDocumento WHERE TipoDeDocumentoId=@id";
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

        public bool Existe(TiposDeDocumento tiposDeDocumento)
        {
            if (tiposDeDocumento.TipoDeDocumentoId == 0)
            {
                string cadenaComando = "select TipoDeDocumentoId,NombreDocumento from TiposDeDocumento where NombreDocumento=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", tiposDeDocumento.NombreDocumento);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando = "select TipoDeDocumentoId,NombreDocumento from TiposDeDocumento where NombreDocumento=@nom and TipoDeDocumentoId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nom", tiposDeDocumento.NombreDocumento);
                comando.Parameters.AddWithValue("@id", tiposDeDocumento.TipoDeDocumentoId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public List<TiposDeDocumento> GetTiposDeDocumentos()
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
            catch (Exception)
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
            if (tiposDeDocumento.TipoDeDocumentoId == 0)
            {

                try
                {
                    string cadenaComando = "insert into TiposdeDocumento values(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", tiposDeDocumento.NombreDocumento);

                    comando.ExecuteNonQuery();
                    cadenaComando = "select @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    tiposDeDocumento.TipoDeDocumentoId = (int)(decimal)comando.ExecuteScalar();


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
                    string cadenaComando = "UPDATE TiposdeDocumento SET NombreDocumento=@nombre WHERE TipoDeDocumentoId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", tiposDeDocumento.NombreDocumento);
                    comando.Parameters.AddWithValue("@id", tiposDeDocumento.TipoDeDocumentoId);
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
