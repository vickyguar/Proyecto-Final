using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_Entidades
    {
        public class INVESTIGADOR_Ent
        {
            public uint id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }

            //foreign keys
            public List<uint> id_Proyecto { get; set; }

            //TODO: Agregué estos dos acá para validar.
            private string Usuario { get; set; }
            private string Contrasena { get; set; } 
            private uint Administrador { get; set; }

            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_Clases
    {
        public class INVESTIGADOR_BLL
        {

        }
    }
    namespace BLL_Map
    {
        public class INVESTIGADOR_Map
        {

        }
    }
}
