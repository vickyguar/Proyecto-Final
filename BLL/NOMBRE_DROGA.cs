using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    namespace BLL_Entidades
    {
        public class NOMBRE_DROGA_Ent
        {
            public uint id { get; set; }
            public string NombreDroga { get; set; }
            public uint CatalogNum { get; set; }
            // TODO: para mi se fue ayer

            public uint id_inyeccion { get; set; }
            public bool eliminado { get; set; }
        }
    }
    namespace BLL_Clases
    {
        public class NOMBRE_DROGA_BLL
        {
            public int AgregarUno(uint id, string nombre_droga, uint catalog_num, uint id_inyeccion)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                int resultado = map.AgregarUno(id, nombre_droga, catalog_num, id_inyeccion);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_droga, uint catalog_num, uint id_inyeccion, bool eliminado)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                int resultado = map.ModificarUno(id, nombre_droga, catalog_num, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_Entidades.NOMBRE_DROGA_Ent BuscarUno(uint id)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                BLL_Entidades.NOMBRE_DROGA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.NOMBRE_DROGA_Ent> BuscarTodos()
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                List<BLL_Entidades.NOMBRE_DROGA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_Entidades.NOMBRE_DROGA_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                List<BLL_Entidades.NOMBRE_DROGA_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.NOMBRE_DROGA_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreDroga, a.CatalogNum.ToString(), "Droga" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.NOMBRE_DROGA_Map map = new BLL_Map.NOMBRE_DROGA_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }
    namespace BLL_Map
    {
        public class NOMBRE_DROGA_Map
        {
            public int ModificarUno(uint id, string nombre_droga, uint catalog_num, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }

            public int AgregarUno(uint id, string nombre_droga, uint catalog_num, uint id_inyeccion)
            {
                return 1;
            }
            public BLL_Entidades.NOMBRE_DROGA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_Entidades.NOMBRE_DROGA_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_Entidades.NOMBRE_DROGA_Ent> BuscarTodos(uint id_inyeccion)
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