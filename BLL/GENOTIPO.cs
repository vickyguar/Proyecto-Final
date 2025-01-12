using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BLL.BLL_ENT;

namespace BLL
{
	namespace BLL_ENT
    {
		public class GENOTIPO_Ent
		{
			public uint id { get; set; }
			public string NombreGenotipo { get; set; }
			public bool Eliminado { get; set; }
		}
	}

	namespace BLL_CLASS
    {
		public class GENOTIPO_Class
        {
            //CREATE
            public int Agregar(string nombre_genotipo)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.Agregar(nombre_genotipo);
                map = null;
                return resultado;
            }

            //UPDATE
            public int Actualizar(uint id, string nombre_genotipo, bool eliminado)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.Actualizar(id, nombre_genotipo, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENT.GENOTIPO_Ent Buscar(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                BLL_ENT.GENOTIPO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            
            public List<BLL_ENT.GENOTIPO_Ent> BuscarTodos()
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                List<BLL_ENT.GENOTIPO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.GENOTIPO_Ent a = this.Buscar(id);

                string[] datos = { a.NombreGenotipo, "Cepa" };

                return datos;
            }
            public int Borrar(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }
	
	namespace BLL_MAP
    {
		public class GENOTIPO_Map
        {
            public int Agregar(string nombre_genotipo)
            {
                return 1;
            }
            public int Actualizar(uint id, string nombre_genotipo, bool eliminado)
            {
                return 1;
            }

            #region 
            public BLL_ENT.GENOTIPO_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.GENOTIPO_Ent> BuscarTodos()
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
            #endregion
        }
    }
}