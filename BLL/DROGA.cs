using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_ENT
    {
        public class DROGA_Ent
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
        public class DROGA_Class
        {
            public int Agregar(string nombre_droga, uint catalog_num)
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                int resultado = map.Agregar(nombre_droga, catalog_num);
                map = null;
                return resultado;
            }
            public int Actualizar(uint id, string nombre_droga, uint catalog_num, bool eliminado)
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                int resultado = map.Actualizar(id, nombre_droga, catalog_num, eliminado);
                map = null;
                return resultado;
            }

            #region 
            public BLL_ENT.DROGA_Ent BuscarUno(uint id)
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                BLL_ENT.DROGA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.DROGA_Ent> BuscarTodos()
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                List<BLL_ENT.DROGA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.DROGA_Ent a = this.BuscarUno(id);

                string[] datos = { a.NombreDroga, a.CatalogNum.ToString(), "Droga" };

                return datos;
            }
            public int Borrar(uint id)
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.DROGA_Map map = new BLL_MAP.DROGA_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }
    namespace BLL_MAP
    {
        public class DROGA_Map
        {
            #region CREATE
            public int Agregar(string nombre_droga, uint catalog_num)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "DROGA_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idDroga y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("NombreDroga", SqlDbType.VarChar);
                Cmd.Parameters["NombreDroga"].Value = nombre_droga;

                Cmd.Parameters.Add("CatalogNum", SqlDbType.Int);
                Cmd.Parameters["CatalogNum"].Value = catalog_num;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_droga, uint catalog_num, bool eliminado)
            {
                return 1;
            }
            #endregion

            #region READ
            public BLL_ENT.NOMBRE_DROGA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.DROGA_Ent> BuscarTodos()
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