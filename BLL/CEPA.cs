using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL {

    namespace BLL_ENT
    {
        public class CEPA_Ent
        {
            public uint id { get; set; }
            public string NombreCepa { get; set; }
            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_CLASS
    {
        public class CEPA_BLL
        {
            #region CREATE
            public int Agregar(string nombre_cepa)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                int resultado = map.Agregar(nombre_cepa);
                map = null;
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_cepa, bool eliminado)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                int resultado = map.Actualizar(id, nombre_cepa, eliminado);
                map = null;
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.CEPA_Ent Buscar(uint id)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                BLL_ENT.CEPA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public BLL_ENT.CEPA_Ent BuscarCepaDeRaton(uint id_raton)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                BLL_ENT.CEPA_Ent ent = map.Buscar(id_raton);
                map = null;
                return ent;
            }
            public List<BLL_ENT.CEPA_Ent> BuscarTodos()
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                List<BLL_ENT.CEPA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.CEPA_Ent a = this.Buscar(id);

                string[] datos = { a.NombreCepa, "Cepa" };

                return datos;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.CEPA_Map map = new BLL_MAP.CEPA_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion
        }
    }

    namespace BLL_MAP
    {
        public class CEPA_Map
        {
            #region CREATE
            public int Agregar(string nombre_cepa)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "CEPA_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idCepa y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("NombreCepa", SqlDbType.VarChar);
                Cmd.Parameters["NombreCepa"].Value = nombre_cepa;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_cepa, bool eliminado)
            {
                return 1;
            }
            #endregion

            #region READ
            public BLL_ENT.CEPA_Ent Buscar(uint id)
            {
                return null;
            }
            public BLL_ENT.CEPA_Ent BuscarCepaDeRaton(uint id_raton)
            {
                return null;
            }
            public List<BLL_ENT.CEPA_Ent> BuscarTodos()
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