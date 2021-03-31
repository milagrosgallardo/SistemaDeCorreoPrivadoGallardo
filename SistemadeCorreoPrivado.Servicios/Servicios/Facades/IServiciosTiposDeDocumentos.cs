using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.Servicios.Servicios.facades
{
    public interface IServiciosTiposDeDocumentos
    {
        List<TiposDeDocumento> GetTiposDeDocumentos();
        TiposDeDocumento GetTiposDeDocumentoPorId(int id);
        void Guardar(TiposDeDocumento tiposDeDocumento);
        void Borrar(int id);
        bool Existe(TiposDeDocumento tiposDeDocumento);
    }
}
