using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.DL.Repositorio.Facades
{
    public interface IRepositorioModalidad
    {
        List<Modalidad> GetModalidades();
        Modalidad GetModalidadPorId(int id);
        void Guardar(Modalidad modalidad);
        void Borrar(int id);
        bool Existe(Modalidad modalidad);
    }
}
