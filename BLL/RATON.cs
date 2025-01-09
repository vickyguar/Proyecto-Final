using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    namespace BLL_Entidades
    {
        public class RATON_Ent
        {
            // Atributos pre-sacrificio
            public uint id { get; set; }
            public eGENERO Genero { get; set; }
            public DateTime FechaNacimiento { get; set; }
            private uint Jaula { get; set; }
            private string MarcaOreja { get; set; }
            private uint Control { get; set; }
            // TODO: No podría ser "Si tratamiento es null → es control: habria que decidir porque en la realidad si recibe tratamiento pero de tipo control

            // foreign keys
            public uint id_Cepa { get; set; }
            public uint id_Genotipo { get; set; }
            public List<uint> id_Seguimiento { get; set; }
            public List<uint> id_Muestras { get; set; }

           
            // Atributos post-sacrificio
            // TODO: null hasta que Sacrificar → habría que tener flag? creo que si, para asegurar q carguen todo
            public DateTime FechaSacrificio { get; set; }
            private float PesoRatonSinTumor { get; set; }
            private string LinkFotoSacrificio { get; set; }


            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_Clases
    {
        public class RATON_BLL
        {

        }
    }
    namespace BLL_Map
    {
        public class RATON_Map
        {

        }
    }
   
}
