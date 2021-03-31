using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios.facades
{
    public interface IServiciosProvincias
    {
        List<Provincia> GetProvincias();
        Provincia GetProvinciaPorId(int id);
        void Guardar(Provincia provincia);
        void Borrar(int id);
        bool Existe(Provincia provincia);
    }
}
