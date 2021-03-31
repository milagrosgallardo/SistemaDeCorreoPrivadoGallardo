using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios.facades
{
    public interface IServiciosTareas
    {
        List<Tarea> GetTareas();
        Tarea GetTareaPorId(int id);
        void Guardar(Tarea tarea);
        void Borrar(int id);
        bool Existe(Tarea tarea);
    }
}
