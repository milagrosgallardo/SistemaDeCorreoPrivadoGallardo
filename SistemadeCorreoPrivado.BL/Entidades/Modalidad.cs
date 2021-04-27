using System;

namespace SistemadeCorreoPrivado.BL.Entidades
{
    public class Modalidad: ICloneable
    {
        public int ModalidadId { get; set; }
        public string NombreModalidad { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
