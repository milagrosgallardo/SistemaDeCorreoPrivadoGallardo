using System;

namespace SistemadeCorreoPrivado.BL.Entidades
{
    public class Zona: ICloneable
    {
        public int ZonaId { get; set; }
        public string NombreZona { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
