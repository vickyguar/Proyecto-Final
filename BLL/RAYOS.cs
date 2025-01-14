using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace BLL
{
	namespace BLL_ENT
    {
        public class RAYOS_Ent
        {
            public uint Sesiones;
            public sCANTIDAD TasaDosis; //velocidad con la que se entrego
            public sCANTIDAD DosisTotal;
            public sCANTIDAD EnergiaRX;

            public string Observacion;
            public uint idExperimento;
            public bool Eliminado;
        }
    }

	namespace BLL_CLASS
    {
        public class RAYOS_Class: ITRATAMIENTO<BLL_ENT.RAYOS_Ent>
        {
            public int Agregar(uint sesiones, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                int resultado = map.Agregar(sesiones, tasa_dosis, dosis_total, energiaRX, observacion, id_experimento);
                map = null;
                return resultado;
            }
            public int Actualizar(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento, bool eliminado)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                int resultado = map.Actualizar(id, tasa_dosis, dosis_total, energiaRX, observacion, id_experimento, eliminado);
                map = null;
                return resultado;
            }

            #region iMPLEMENTADOS DE INTERFAZ
            public BLL_ENT.RAYOS_Ent Buscar(uint id)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                BLL_ENT.RAYOS_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.RAYOS_Ent> BuscarTodos()
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                List<BLL_ENT.RAYOS_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENT.RAYOS_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                List<BLL_ENT.RAYOS_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.RAYOS_Ent a = this.Buscar(id);

                string[] datos = { a.DosisTotal.ToString(), a.EnergiaRX.ToString(), a.TasaDosis.ToString(), a.Observacion, "TRATAMIENTO x RAYOS" };

                return datos;
            }

            public int Borrar(uint id)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.RAYOS_Map map = new BLL_MAP.RAYOS_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }

	namespace BLL_MAP
    {
        public class RAYOS_Map
        {
            #region CREATE
            public int Agregar(uint sesiones, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "RAYOS_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idTratamiento y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idExperimento", SqlDbType.Int);
                Cmd.Parameters["idExperimento"].Value = id_experimento;

                Cmd.Parameters.Add("Sesiones", SqlDbType.Int);
                Cmd.Parameters["Sesiones"].Value = sesiones;

                Cmd.Parameters.Add("Observacion", SqlDbType.NVarChar);
                Cmd.Parameters["Observacion"].Value = observacion;


                //TODO: que se hace en la MAP con sCANTIDAD -> 1 float y un varchar?
                Cmd.Parameters.Add("TasaDosis.Magnitud", SqlDbType.Float);
                Cmd.Parameters["TasaDosis.Magnitud"].Value = tasa_dosis.Magnitud;
                Cmd.Parameters.Add("TasaDosis.Unidad", SqlDbType.VarChar,10);
                Cmd.Parameters["TasaDosis.Unidad"].Value = tasa_dosis.Unidad;

                Cmd.Parameters.Add("DosisTotal.Magnitud", SqlDbType.Float);
                Cmd.Parameters["DosisTotal.Magnitud"].Value = dosis_total.Magnitud;
                Cmd.Parameters.Add("DosisTotal.Unidad", SqlDbType.VarChar, 10);
                Cmd.Parameters["DosisTotal.Unidad"].Value = dosis_total.Unidad;

                Cmd.Parameters.Add("EnergiaRX.Magnitud", SqlDbType.Float);
                Cmd.Parameters["EnergiaRX.Magnitud"].Value = dosis_total.Magnitud;
                Cmd.Parameters.Add("EnergiaRX.Unidad", SqlDbType.VarChar, 10);
                Cmd.Parameters["EnergiaRX.Unidad"].Value = dosis_total.Unidad;


                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento, bool eliminado)
            {
                return 1;
            }
            #endregion

            #region READ
            public BLL_ENT.RAYOS_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_ENT.RAYOS_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.RAYOS_Ent> BuscarTodos(uint id_experimento)
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