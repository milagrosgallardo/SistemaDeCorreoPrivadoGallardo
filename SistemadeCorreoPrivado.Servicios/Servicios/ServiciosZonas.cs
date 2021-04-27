using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL;
using SistemadeCorreoPrivado.DL.Repositorio;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios
{
    public class ServiciosZonas : IServiciosZonas
    {
        private IRepositorioZonas _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosZonas()
        {

        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioZonas(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Zona zona)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioZonas(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(zona);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Zona> GetZonas()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioZonas(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetZonas();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Zona GetZonasPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Zona zona)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioZonas(_conexionBd.AbrirConexion());
                _repositorio.Guardar(zona);
                _conexionBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
