using System;

namespace SistemadeCorreoPrivado.BL.Entidades
{
    public class Provincia:ICloneable

    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }

        public object Clone()
        {// este objeto hace una copia superficial del objeto 
            return this.MemberwiseClone();
        }
    }
}
