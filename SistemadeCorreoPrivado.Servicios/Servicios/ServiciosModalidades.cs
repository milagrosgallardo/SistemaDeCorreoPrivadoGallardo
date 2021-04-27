using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL;
using SistemadeCorreoPrivado.DL.Repositorio;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios
{
    public class ServiciosModalidades : IServiciosModalidades
    {
        private RepositorioModalidades _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosModalidades()
        {

        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioModalidades(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Modalidad modalidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioModalidades(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(modalidad);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Modalidad> GetModalidades()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioModalidades(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetModalidades();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Modalidad GetModalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Modalidad modalidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioModalidades(_conexionBd.AbrirConexion());
                _repositorio.Guardar(modalidad);
                _conexionBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
