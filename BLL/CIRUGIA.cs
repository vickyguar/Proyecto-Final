using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL {

    namespace BLL_ENT
    {
        public class CIRUGIA_Ent
        {
            public uint id { get; set; }
            public sCANTIDAD PorcentajeExtirpado { get; set; } // aca es la dosis mg/kg
            public DateTime FechaCirugia { get; set; }
            public string Observacion { get; set; }

            public uint idExperimento { get; set; }

            public bool Eliminado { get; set; }
        }
    }

    namespace BLL_CLASS
    {
        public class CIRUGIA_Class: ITRATAMIENTO<BLL_ENT.CIRUGIA_Ent>
        {
            int Agregar(sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                int resultado = map.Agregar(porcentaje_extirpado, fecha_cirugia, observacion, id_experimento);
                map = null;
                return resultado;
            }
            int Actualizar(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento, bool eliminado)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                int resultado = map.Actualizar(id, porcentaje_extirpado, fecha_cirugia, observacion, id_experimento, eliminado);
                map = null;
                return resultado;
            }

            #region iMPLEMENTADOS DE INTERFAZ
            public BLL_ENT.CIRUGIA_Ent Buscar(uint id)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                BLL_ENT.CIRUGIA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.CIRUGIA_Ent> BuscarTodos()
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                List<BLL_ENT.CIRUGIA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENT.CIRUGIA_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                List<BLL_ENT.CIRUGIA_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.CIRUGIA_Ent a = this.Buscar(id);

                string[] datos = { a.FechaCirugia.ToString(), a.PorcentajeExtirpado.ToString(), a.Observacion, "Cirugia" };

                return datos;
            }

            public int Borrar(uint id)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.CIRUGIA_Map map = new BLL_MAP.CIRUGIA_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion
        }

    }

	namespace BLL_MAP
    {
        public class CIRUGIA_Map
        {
            #region CREATE
            public int Agregar(sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "CIRUGIA_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idExperimento y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idExperimento", SqlDbType.Int);
                Cmd.Parameters["idExperimento"].Value = id_experimento;

                Cmd.Parameters.Add("FechaCirugia", SqlDbType.DateTime);
                Cmd.Parameters["FechaCirugia"].Value = fecha_cirugia;

                Cmd.Parameters.Add("Observacion", SqlDbType.NVarChar);
                Cmd.Parameters["Observacion"].Value = observacion;

                //TODO: que se hace en la MAP con sCANTIDAD
                Cmd.Parameters.Add("PorcentajeExtirpado.Magnitud", SqlDbType.Float);
                Cmd.Parameters["PorcentajeExtirpado.Magnitud"].Value = porcentaje_extirpado.Magnitud;
                Cmd.Parameters.Add("PorcentajeExtirpado.Unidad", SqlDbType.VarChar, 10);
                Cmd.Parameters["PorcentajeExtirpado.Unidad"].Value = porcentaje_extirpado.Unidad;


                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento, bool eliminado)
            {
                return 1;
            }
            #endregion

            #region READ
            public BLL_ENT.CIRUGIA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.CIRUGIA_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.CIRUGIA_Ent> BuscarTodos(uint id_experimento)
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