using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL;
using SistemadeCorreoPrivado.DL.Repositorio;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios
{
    public class ServiciosTiposDeDocumentos : IServiciosTiposDeDocumentos
    {
        private IRepositorioTiposDeDocumentos _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosTiposDeDocumentos()
        {

        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TiposDeDocumento tiposDeDocumento)
        {
            throw new NotImplementedException();
        }

        public List<TiposDeDocumento> GetTiposDeDocumentos()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTiposDeDocumentos(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetTiposDeDocumento();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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
