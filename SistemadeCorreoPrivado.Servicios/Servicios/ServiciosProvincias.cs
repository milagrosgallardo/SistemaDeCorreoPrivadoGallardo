using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.DL;
using SistemadeCorreoPrivado.DL.Repositorio;
using SistemadeCorreoPrivado.DL.Repositorio.Facades;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios
{
    public class ServiciosProvincias : IServiciosProvincias
    {   //pido las provincias al repositorio a traves de una conexion
        private IRepositorioProvincias _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosProvincias()
        {

        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(provincia);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Provincia> GetProvincias()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetProvincias();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Provincia provincia)
        {
            try
            {// hago la conexion 
                _conexionBd = new ConexionBd();
                // creo el repositorio
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                //guarda la provincia
                _repositorio.Guardar(provincia);
                //cierro la conexion
                _conexionBd.CerrarConexion();
       
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
