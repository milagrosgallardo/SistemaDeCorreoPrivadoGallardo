using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.DL.Repositorio.Facades
{
    public interface IRepositorioZonas
    {
        List<Zona> GetZonas();
        Zona GetZonaPorId(int id);
        void Guardar(Zona zona);
        void Borrar(int id);
        bool Existe(Zona zona);
    }
}
