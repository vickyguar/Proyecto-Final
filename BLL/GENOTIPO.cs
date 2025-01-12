using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	namespace BLL_ENTITY
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
		public class GENOTIPO_BLL
        {
            public int Agregar(string nombre_genotipo)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.Agregar(nombre_genotipo);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_genotipo, bool eliminado)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.ModificarUno(id, nombre_genotipo, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENTITY.GENOTIPO_Ent BuscarUno(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                BLL_ENTITY.GENOTIPO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            
            public List<BLL_ENTITY.GENOTIPO_Ent> BuscarTodos()
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                List<BLL_ENTITY.GENOTIPO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENTITY.GENOTIPO_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreGenotipo, "Cepa" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_MAP.GENOTIPO_Map map = new BLL_MAP.GENOTIPO_Map();
                int resultado = map.DeshacerBorrarUno(id);
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
            public int ModificarUno(uint id, string nombre_genotipo, bool eliminado)
            {
                return 1;
            }

            #region 
            public BLL_ENTITY.GENOTIPO_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENTITY.GENOTIPO_Ent> BuscarTodos()
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