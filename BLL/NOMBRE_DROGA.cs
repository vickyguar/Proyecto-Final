using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    namespace BLL_ENT
    {
        public class NOMBRE_DROGA_Ent
        {
            public uint id { get; set; }
            public string NombreDroga { get; set; }
            public uint CatalogNum { get; set; }
            // TODO: para mi se fue ayer
            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_CLASS
    {
        public class NOMBRE_DROGA_Class
        {
            public int Agregar(string nombre_droga, uint catalog_num)
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                int resultado = map.Agregar(nombre_droga, catalog_num);
                map = null;
                return resultado;
            }
            public int Actualizar(uint id, string nombre_droga, uint catalog_num, bool eliminado)
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                int resultado = map.Actualizar(id, nombre_droga, catalog_num, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENT.NOMBRE_DROGA_Ent BuscarUno(uint id)
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                BLL_ENT.NOMBRE_DROGA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.NOMBRE_DROGA_Ent> BuscarTodos()
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                List<BLL_ENT.NOMBRE_DROGA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.NOMBRE_DROGA_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreDroga, a.CatalogNum.ToString(), "Droga" };

                return datos;
            }
            public int Borrar(uint id)
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.NOMBRE_DROGA_Map map = new BLL_MAP.NOMBRE_DROGA_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }
    namespace BLL_MAP
    {
        public class NOMBRE_DROGA_Map
        {
            public int Actualizar(uint id, string nombre_droga, uint catalog_num, bool eliminado)
            {
                return 1;
            }

            public int Agregar(string nombre_droga, uint catalog_num)
            {
                return 1;
            }
            public BLL_ENT.NOMBRE_DROGA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.NOMBRE_DROGA_Ent> BuscarTodos()
            {
                return null;
            }
            public int Borrar(uint id)
            {
                return 1;
            }
            public int DeshacerBorrar(uint id)
            {
                return 1;
            }
        }
    }
   
}