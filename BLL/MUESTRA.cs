using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// TODO: resolver acá

namespace BLL
{
    namespace BLL_CLASS
    {
        public class MUESTRA_CLASS
        {
            // CREATE
            // TODO: ver si es posible (lo mismo aplica en todas las clases para hacer el 'Agregar')
            //      - el id no se lo paso porque quizás se pueda tildar autoincremental
            //      - el deleted no se lo paso porque porque quizás se pueda tildar default value 0
            public int Agregar(uint idNombreMuestra, uint idNombreTecnica, uint idRaton, DateTime FechaMuestra, string NumHistopato)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                int resultado = map.Agregar(idNombreMuestra, idNombreTecnica, idRaton, FechaMuestra, NumHistopato);
                map = null;
                return resultado;
            }

        }
    }
    
    namespace BLL_ENTITY
    {
        public class MUESTRA_ENT
        {
            public uint id { get; set; }
            public uint idNombreMuestra { get; set; } // FK
            public uint idNombreTecnica { get; set; } // FK → TODO: siento que esta FK se puede agregar después de ser creada
            public uint idRaton { get; set; } // FK
            public DateTime FechaMuestra { get; set; }
            public string NumHistopato { get; set; } //TODO: NumHistopato, ¿aplica solo para cuando se lleva la muestra al micrótomo? Sangre y heces no se mandan al micrótomo, siento que es atributo de órgano y tumor
            public uint deleted { get; set; }
        }
    }
    namespace BLL_MAP
    {
        public class MUESTRA_MAP
        {

        }
    }
}