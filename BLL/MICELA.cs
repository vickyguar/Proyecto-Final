using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_ENT
    {
        public class MICELA_Ent
        { 
            public uint id { get; set; }
            public string NombreMicela { get; set; }
            public bool Blanco { get; set; }
            public sCANTIDAD ConcentracionDrogaxMicela { get; set; }
            public uint idInyeccion { get; set; }
            // no lo borro x si queda muchos a muchos -> seria List
            public bool Eliminado { get; set; }

            // TODO: resolver acá
            /// Micela Cargada de PTX viene en [ ] fija ConcentracionDrogaxMicela = 4 mg/ml & al animal se inyecta 10 mg/kg PTX x cálculo que hacen (esta concentracion es de la inyeccion)

            /// blanco = soluplus, +6ps: ConcentracionDrogaxMicela = 0
            /// cargadas (droga) = soluplus+ -> HA, PTX: en architect la droga la agregamos a inyeccion de manera independiente de la micela + comentario? 

        }
    }
    namespace BLL_CLASS
    {
        public class MICELA_Class
        {
            #region CREATE
            public int Agregar(string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.Agregar(nombre_micela, blanco, concentracion, id_inyeccion);
                map = null;
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion, bool eliminado)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.Actualizar(id, nombre_micela, blanco, concentracion, id_inyeccion, eliminado);
                map = null;
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.MICELA_Ent Buscar(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                BLL_ENT.MICELA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.MICELA_Ent> BuscarTodos()
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                List<BLL_ENT.MICELA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENT.MICELA_Ent> BuscarTodos(uint id_inyeccion)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                List<BLL_ENT.MICELA_Ent> l = map.BuscarTodos(id_inyeccion);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.MICELA_Ent a = this.Buscar(id);

                string[] datos = { a.NombreMicela, a.ConcentracionDrogaxMicela.ToString(), a.Blanco.ToString(), "Micela" };

                return datos;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.MICELA_Map map = new BLL_MAP.MICELA_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }

            #endregion
        }
    }
    namespace BLL_MAP
    {
        public class MICELA_Map
        {
            #region CREATE
            public int Agregar(string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "MICELA_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idDroga y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("NombreMicela", SqlDbType.VarChar);
                Cmd.Parameters["NombreMicela"].Value = nombre_micela;

                Cmd.Parameters.Add("Blanco", SqlDbType.Int);
                Cmd.Parameters["Blanco"].Value = blanco;

                //TODO: sCantidad va con 2 ints?
                Cmd.Parameters.Add("Concentracion.Magnitud", SqlDbType.Float);
                Cmd.Parameters["Concentracion.Magnitud"].Value = concentracion.Magnitud;
                Cmd.Parameters.Add("Concentracion.Unidad", SqlDbType.Char,10);
                Cmd.Parameters["Concentracion.Unidad"].Value = concentracion.Unidad;

                Cmd.Parameters.Add("idInyeccion", SqlDbType.Int);
                Cmd.Parameters["idInyeccion"].Value = id_inyeccion;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre_micela, bool blanco, sCANTIDAD concentracion, uint id_inyeccion, bool eliminado)
            {
                return 1;
            }

            #endregion

            #region READ
            public BLL_ENT.MICELA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.MICELA_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.MICELA_Ent> BuscarTodos(uint id_inyeccion)
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