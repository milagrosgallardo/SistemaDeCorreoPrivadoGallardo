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
            throw new NotImplementedException();
        }

        public bool Existe(Tarea tarea)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
