using System;

namespace SistemadeCorreoPrivado.BL.Entidades
{
    public class Tarea: ICloneable
    {
        public int TareaId { get; set; }
        public string NombreTarea
        { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
