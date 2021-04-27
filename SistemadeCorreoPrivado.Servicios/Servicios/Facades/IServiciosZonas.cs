using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios.facades
{
    public interface IServiciosZonas
    {
        List<Zona> GetZonas();
        Zona GetZonasPorId(int id);
        void Guardar(Zona zona);
        void Borrar(int id);
        bool Existe(Zona zona);
    }
}
