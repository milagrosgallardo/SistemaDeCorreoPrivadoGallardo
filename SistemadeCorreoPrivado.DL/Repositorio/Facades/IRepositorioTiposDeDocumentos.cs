using SistemadeCorreoPrivado.BL.Entidades;
using System.Collections.Generic;

namespace SistemadeCorreoPrivado.DL.Repositorio.Facades
{
    public interface IRepositorioTiposDeDocumentos
    {
        List<TiposDeDocumento> GetTiposDeDocumento();
        TiposDeDocumento GetTiposDeDocumentoPorId(int id);
        void Guardar(TiposDeDocumento tiposDeDocumento);
        void Borrar(int id);
        bool Existe(TiposDeDocumento tiposDeDocumento);
    }
}