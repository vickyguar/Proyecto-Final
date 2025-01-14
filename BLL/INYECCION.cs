using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_ENT
    {
        public class INYECCION_Ent
        {
            public uint id { get; set; }
            public sCANTIDAD Dosis { get; set; } // aca es la dosis mg/kg
            public string Observacion { get; set; }

            public eADMINISTRACION Administracion { get; set; }
            public sCANTIDAD PeriodoTratamiento { get; set; }
            public uint idDroga { get; set; } // TODO: deberia ser list?
            public uint idVehiculo { get; set; } //TODO: vuela?
            public uint idExperimento { get; set; }
            public uint idMicela { get; set; }
            //TODO: en el architect pusimos hasta 2 micelas por lo que tendriamos que poner list pero era para permitirles poner la micela tratamiento y la blanco... charlar con las chicas si pasamos a relacion muchos a muchos

            public bool Eliminado { get; set; }
        }

    }
    
    namespace BLL_CLASS
    {
        public class INYECCION_Class : ITRATAMIENTO<BLL_ENT.INYECCION_Ent>
        {
            int Agregar(sCANTIDAD dosis, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.Agregar(dosis, observacion, admin, id_droga, id_vehiculo, id_experimento);
                map = null;
                return resultado;
            }

            int Actualizar(uint id, sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.Actualizar(id, tratamiento, admin, id_droga, id_vehiculo, id_experimento, observacion);
                map = null;
                return resultado;
            }

            public List<BLL_ENT.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENT.INYECCION_Ent> l = map.BuscarTodosxMicela(id_micela);
                map = null;
                return l;
            }

            #region iMPLEMENTADOS DE INTERFAZ

            public BLL_ENT.INYECCION_Ent Buscar(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                BLL_ENT.INYECCION_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.INYECCION_Ent> BuscarTodos()
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENT.INYECCION_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENT.INYECCION_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENT.INYECCION_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_ENT.INYECCION_Ent a = this.Buscar(id);

                string[] datos = { a.Administracion.ToString(), a.Dosis.ToString(), a.Observacion, "Tratamiento x Inyeccion" };

                // TODO: deberiamos ver como hariamos para devolver info de la droga, vehiculo, experimento correspondiente 

                return datos;
            }

            public int Borrar(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion
        
        }

    }
   
    namespace BLL_MAP
    {
        public class INYECCION_Map
        {
            #region CREATE

            public int Agregar(sCANTIDAD dosis, string observacion, eADMINISTRACION admin,  uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "INYECCION_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idExperimento y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idExperimento", SqlDbType.Int);
                Cmd.Parameters["idExperimento"].Value = id_experimento;

                Cmd.Parameters.Add("idVehiculo", SqlDbType.Int);
                Cmd.Parameters["idVehiculo"].Value = id_vehiculo;

                Cmd.Parameters.Add("idDroga", SqlDbType.Int);
                Cmd.Parameters["idDroga"].Value = id_droga;

                Cmd.Parameters.Add("Administracion", SqlDbType.Int);
                Cmd.Parameters["Administracion"].Value = admin;

                Cmd.Parameters.Add("Observacion", SqlDbType.NVarChar);
                Cmd.Parameters["Observacion"].Value = observacion;

                //TODO: que se hace en la MAP con sCANTIDAD 
                Cmd.Parameters.Add("Dosis.Magnitud", SqlDbType.Float);
                Cmd.Parameters["Dosis.Magnitud"].Value = dosis.Magnitud;
                Cmd.Parameters.Add("Dosis.Unidad", SqlDbType.VarChar, 10);
                Cmd.Parameters["Dosis.Unidad"].Value = dosis.Unidad;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            public int Actualizar(uint id, sCANTIDAD tratamiento, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento, string observacion)
            {
                return 1;
            }

            #endregion

            #region READ
            public List<BLL_ENT.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                return null;
            }
          
            public BLL_ENT.INYECCION_Ent Buscar(uint id)
            { 
                return null;
            }
            public List<BLL_ENT.INYECCION_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.INYECCION_Ent> BuscarTodos(uint id_experimento)
            {
                return null;
            }

            #endregion

            #region DELETE
            public int Borrar(uint id) {
                return 1;
            }

            public int DeshacerBorrar(uint id) {
                return 1; 
            }
            #endregion
        }
    }
}