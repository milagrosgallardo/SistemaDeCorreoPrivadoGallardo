using System;

namespace SistemadeCorreoPrivado.BL.Entidades
{
    public class TiposDeDocumento: ICloneable
    {
        public int TipoDeDocumentoId
        { get; set; }
        public string NombreDocumento
        { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
