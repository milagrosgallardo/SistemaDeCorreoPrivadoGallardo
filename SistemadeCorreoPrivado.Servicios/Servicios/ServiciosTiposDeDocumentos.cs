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
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTiposDeDocumentos(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(TiposDeDocumento tiposDeDocumento)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTiposDeDocumentos(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(tiposDeDocumento);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TiposDeDocumento> GetTiposDeDocumentos()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTiposDeDocumentos(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetTiposDeDocumentos();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public TiposDeDocumento GetTiposDeDocumentoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TiposDeDocumento tiposDeDocumento)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTiposDeDocumentos(_conexionBd.AbrirConexion());
                _repositorio.Guardar(tiposDeDocumento);
                _conexionBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
