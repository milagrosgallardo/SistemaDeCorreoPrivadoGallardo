using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.DL.Repositorio.Facades
{
    public interface IRepositorioTareas
    {
        List<Tarea> GetTarea();
        Tarea GetTareaPorId(int id);
        void Guardar(Tarea tarea);
        void Borrar(int id);
        bool Existe(Tarea tarea);
    }
}
