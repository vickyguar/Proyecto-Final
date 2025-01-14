using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{

    namespace BLL_ENT
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
        public class VEHICULO_Class
        {
            #region CREATE
            public int Agregar(string nombre_vehiculo, uint id_inyeccion)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.Agregar(nombre_vehiculo, id_inyeccion);
                map = null;
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.Actualizar(id, nombre_vehiculo, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.VEHICULO_Ent Buscar(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                BLL_ENT.VEHICULO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.VEHICULO_Ent> BuscarTodos()
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                List<BLL_ENT.VEHICULO_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENT.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                List<BLL_ENT.VEHICULO_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.VEHICULO_Ent a = this.Buscar(id);

                string[] datos = { a.NombreVehiculo, "Vehiculo" };

                return datos;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.VEHICULO_Map map = new BLL_MAP.VEHICULO_Map();
                int resultado = map.DeshacerBorrar(id);
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
            #region CREATE
            public int Agregar(string nombre_vehiculo, uint id_inyeccion)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "VEHICULO_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idVehiculo y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idInyeccion", SqlDbType.Int);
                Cmd.Parameters["idInyeccion"].Value = id_inyeccion;

                Cmd.Parameters.Add("NombreVehiculo", SqlDbType.VarChar);
                Cmd.Parameters["NombreVehiculo"].Value = nombre_vehiculo;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }

            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_vehiculo, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }
            #endregion

            #region READ

            public BLL_ENT.VEHICULO_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.VEHICULO_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.VEHICULO_Ent> BuscarTodos(uint id_inyeccion)
            {
                return null;
            }

            #endregion


            #region DELETE

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