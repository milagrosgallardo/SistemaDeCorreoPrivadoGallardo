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
            throw new NotImplementedException();
        }

        public bool Existe(Zona zonas)
        {
            throw new NotImplementedException();
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
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Zona GetZonasPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Zona Zona)
        {
            throw new NotImplementedException();
        }
    }
}
