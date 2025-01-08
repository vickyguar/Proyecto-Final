using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{

    namespace BLL_Entidades
    {
        public class VEHICULO_Ent
        {
            public uint id { get; set; }
            public string NombreVehiculo { get; set; }
            public uint id_inyeccion { get; set; }
            public bool eliminado { get; set; }
        }
    }
    namespace BLL_Clases
    {
        public class VEHICULO_BLL
        {
            public int AgregarUno(uint id, string nombre_vehiculo, uint id_inyeccion)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                int resultado = map.AgregarUno(id, nombre_vehiculo, id_inyeccion);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                int resultado = map.ModificarUno(id, nombre_vehiculo, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_Entidades.VEHICULO_Ent BuscarUno(uint id)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                BLL_Entidades.VEHICULO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.VEHICULO_Ent> BuscarTodos()
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                List<BLL_Entidades.VEHICULO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_Entidades.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                List<BLL_Entidades.VEHICULO_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.VEHICULO_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreVehiculo, "Vehiculo" };

                return datos;
            }
            public int BorrarUno(uint id)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.VEHICULO_Map map = new BLL_Map.VEHICULO_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }
    namespace BLL_Map
    {
        public class VEHICULO_Map
        {
            public int ModificarUno(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }

            public int AgregarUno(uint id, string nombre_vehiculo, uint id_inyeccion)
            {
                return 1;
            }
            public BLL_Entidades.VEHICULO_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_Entidades.VEHICULO_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_Entidades.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
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