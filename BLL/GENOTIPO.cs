using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	namespace BLL_Entidades
	{
		public class GENOTIPO_Ent
		{
			public uint id { get; set; }
			public string NombreGenotipo { get; set; }

			public uint id_raton { get; set; }
			public bool Eliminado { get; set; }
		}
	}

	namespace BLL_Clases
    {
		public class GENOTIPO_BLL
        {
            public int AgregarUno(uint id, string nombre_genotipo, uint id_raton)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                int resultado = map.AgregarUno(id, nombre_genotipo, id_raton);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_genotipo, uint id_raton, bool eliminado)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                int resultado = map.ModificarUno(id, nombre_genotipo, id_raton, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_Entidades.GENOTIPO_Ent BuscarUno(uint id)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                BLL_Entidades.GENOTIPO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public BLL_Entidades.GENOTIPO_Ent BuscarCepaDeRaton(uint id_raton)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                BLL_Entidades.GENOTIPO_Ent ent = map.Buscar(id_raton);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.GENOTIPO_Ent> BuscarTodos()
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                List<BLL_Entidades.GENOTIPO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.GENOTIPO_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreGenotipo, "Cepa" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.GENOTIPO_Map map = new BLL_Map.GENOTIPO_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }
	
	namespace BLL_Map
    {
		public class GENOTIPO_Map
        {
            public int AgregarUno(uint id, string nombre_genotipo, uint id_raton)
            {
                return 1;
            }
            public int ModificarUno(uint id, string nombre_genotipo, uint id_raton, bool eliminado)
            {
                return 1;
            }

            #region 
            public BLL_Entidades.GENOTIPO_Ent Buscar(uint id)
            {
                return null;
            }
            public BLL_Entidades.GENOTIPO_Ent BuscarCepaDeRaton(uint id_raton)
            {
                return null;
            }
            public List<BLL_Entidades.GENOTIPO_Ent> BuscarTodos()
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