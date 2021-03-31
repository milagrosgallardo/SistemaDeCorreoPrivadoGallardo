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
            throw new NotImplementedException();
        }

        public bool Existe(Modalidad modalidad)
        {
            throw new NotImplementedException();
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
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Modalidad GetModalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Modalidad modalidad)
        {
            throw new NotImplementedException();
        }
    }
}
