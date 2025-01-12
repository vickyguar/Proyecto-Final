using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{

    namespace BLL_ENTITY
    {
        public class VEHICULO_Ent
        {
            public uint id { get; set; }
            public string NombreVehiculo { get; set; }
            public uint idInyeccion { get; set; }
            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_CLASS
    {
        public class VEHICULO_BLL
        {
            public int Agregar(string nombre_vehiculo, uint id_inyeccion)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.Agregar(nombre_vehiculo, id_inyeccion);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.ModificarUno(id, nombre_vehiculo, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENTITY.VEHICULO_Ent Buscar(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                BLL_ENTITY.VEHICULO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.VEHICULO_Ent> BuscarTodos()
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                List<BLL_ENTITY.VEHICULO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENTITY.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                List<BLL_ENTITY.VEHICULO_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENTITY.VEHICULO_Ent a = this.Buscar(id);

                string[] datos = { a.NombreVehiculo, "Vehiculo" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }
    namespace BLL_MAP
    {
        public class VEHICULO_Map
        {
            public int ModificarUno(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }

            public int Agregar(string nombre_vehiculo, uint id_inyeccion)
            {
                return 1;
            }
            public BLL_ENTITY.VEHICULO_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENTITY.VEHICULO_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENTITY.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
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