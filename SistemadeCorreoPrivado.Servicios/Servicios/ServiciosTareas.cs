using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL;
using SistemadeCorreoPrivado.DL.Repositorio;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios
{
    public class ServiciosTareas : IServiciosTareas
    {
        private IRepositorioTareas _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosTareas()
        {

        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTareas(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Tarea tarea)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTareas(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(tarea);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Tarea> GetTareas()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTareas(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetTareas();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Tarea GetTareaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Tarea tarea)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTareas(_conexionBd.AbrirConexion());
                _repositorio.Guardar(tarea);
                _conexionBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
