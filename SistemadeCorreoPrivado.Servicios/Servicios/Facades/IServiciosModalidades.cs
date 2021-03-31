using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios.facades
{
    public interface IServiciosModalidades
    {
        List<Modalidad> GetModalidades();
        Modalidad GetModalidadPorId(int id);
        void Guardar(Modalidad modalidad);
        void Borrar(int id);
        bool Existe(Modalidad modalidad);
    }
}
