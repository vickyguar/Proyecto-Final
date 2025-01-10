using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    

    namespace BLL_ENTITY
    {
        // Aca deje un comentario
        public class EXPERIMENTO_ENT
        {
            public string Titulo { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public eESTADO Estado { get; set; }
            public uint id { get; set; }
            public uint idProyecto { get; set; } // FKO
            public uint deleted { get; set; }
        }
    }
}
