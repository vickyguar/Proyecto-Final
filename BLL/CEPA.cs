using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL {

    namespace BLL_Entidades
    {
        public class CEPA_Ent
        {
            public uint id { get; set; }
            public string NombreCepa { get; set; }
            public List<uint> id_raton { get; set; }
            public bool eliminado { get; set; }
        }
    }
    namespace BLL_Clases
    {
        public class CEPA_BLL
        {
            public int AgregarUno(uint id, string nombre_cepa, uint id_raton)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                int resultado = map.AgregarUno(id, nombre_cepa, id_raton);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_cepa, uint id_raton, bool eliminado)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                int resultado = map.ModificarUno(id, nombre_cepa, id_raton, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_Entidades.CEPA_Ent BuscarUno(uint id)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                BLL_Entidades.CEPA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public BLL_Entidades.CEPA_Ent BuscarCepaDeRaton(uint id_raton)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                BLL_Entidades.CEPA_Ent ent = map.Buscar(id_raton);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.CEPA_Ent> BuscarTodos()
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                List<BLL_Entidades.CEPA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.CEPA_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreCepa, "Cepa" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.CEPA_Map map = new BLL_Map.CEPA_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }

    namespace BLL_Map
    {
        public class CEPA_Map
        {
            public int AgregarUno(uint id, string nombre_cepa, uint id_raton)
            {
                return 1;
            }
            public int ModificarUno(uint id, string nombre_cepa, uint id_raton, bool eliminado)
            {
                return 1;
            }

            #region 
            public BLL_Entidades.CEPA_Ent Buscar(uint id)
            {
                return null;
            }
            public BLL_Entidades.CEPA_Ent BuscarCepaDeRaton(uint id_raton)
            {
                return null;
            }
            public List<BLL_Entidades.CEPA_Ent> BuscarTodos()
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
            #endregion

        }
    }
  
}