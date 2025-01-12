using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    namespace BLL_ENTITY
    {
        public class MICELA_Ent
        { 
            public uint id { get; set; }
            public string NombreMicela { get; set; }
            public bool Blanco { get; set; }
            public sCANTIDAD ConcentracionDrogaxMicela { get; set; }
            public uint idInyeccion { get; set; }
            // no lo borro x si queda muchos a muchos -> seria List
            public bool Eliminado { get; set; }

            // TODO: resolver acá
            /// Micela Cargada de PTX viene en [ ] fija ConcentracionDrogaxMicela = 4 mg/ml & al animal se inyecta 10 mg/kg PTX x cálculo que hacen (esta concentracion es de la inyeccion)

            /// blanco = soluplus, +6ps: ConcentracionDrogaxMicela = 0
            /// cargadas (droga) = soluplus+ -> HA, PTX: en architect la droga la agregamos a inyeccion de manera independiente de la micela + comentario? 

        }
    }
    namespace BLL_CLASS
    {
        public class MICELA_BLL
        {
            public int Agregar(string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.Agregar(nombre_micela, blanco, concentracion, id_inyeccion);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion, bool eliminado)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.ModificarUno(id, nombre_micela, blanco, concentracion, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENTITY.MICELA_Ent Buscar(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                BLL_ENTITY.MICELA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.MICELA_Ent> BuscarTodos()
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                List<BLL_ENTITY.MICELA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENTITY.MICELA_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                List<BLL_ENTITY.MICELA_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENTITY.MICELA_Ent a = this.Buscar(id);

                string[] datos = { a.NombreMicela, a.ConcentracionDrogaxMicela.ToString(), a.Blanco.ToString(), "Micela" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }
    namespace BLL_MAP
    {
        public class MICELA_Map
        {
            public int ModificarUno(uint id, string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }

            public int Agregar(string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion)
            {
                return 1;
            }
            public BLL_ENTITY.MICELA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENTITY.MICELA_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENTITY.MICELA_Ent> BuscarTodos(uint id_inyeccion)
            {
                return null;
            }
            public int BorrarUno(uint id)
            {
                return 1;
            }
            public int DeshacerBorrarUno(uint id)
            {
                return 1;
            }
        }
    }
}