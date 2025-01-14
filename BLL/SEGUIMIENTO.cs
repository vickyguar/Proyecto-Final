using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
	namespace BLL_ENT
	{
		public class SEGUIMIENTO_Ent
        {
			public uint id { get; set; }
			public DateTime FechaSeguimiento { get; set; }
			public float PesoRaton { get; set; }
			public float TamanoRaton { get; set; }
			public float VolumenTumor { get; set; }

			//foreign keys
			public uint idRaton { get; set; }
			public uint idExperimento { get; set; }
		
			public bool Eliminado { get; set; }
		}
	}
	namespace BLL_CLASS
	{
		public class SEGUIMIENTO_Class
        {
            #region CREATE
            public int Agregar(uint id_raton, uint id_experimento, DateTime fecha_seguimiento, float peso_raton, float tamano_raton, float a_vol, float b_vol)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                float vol_tumor = CalcularVolumen(a_vol, b_vol);
                int resultado = map.Agregar(id_raton, id_experimento, fecha_seguimiento, peso_raton, tamano_raton, vol_tumor);

                map = null;
                return resultado;
            }

            public float CalcularVolumen(float a, float b)
            {
                float volumenTumor;
                volumenTumor = (float)Math.PI * (float)Math.Pow(a + b, 2) / 12; //TODO: no era asi, pero me lo imaginé
                return volumenTumor;
            }
            #endregion

            #region READ
            public BLL_ENT.SEGUIMIENTO_Ent Buscar(uint id)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                BLL_ENT.SEGUIMIENTO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }

            public List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodos(DateTime fecha_seguimiento)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                List<BLL_ENT.SEGUIMIENTO_Ent> lista = map.BuscarTodos(fecha_seguimiento);
                map = null;
                return lista;
            }

            public List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodosxExperimento(uint id_experimento)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                List<BLL_ENT.SEGUIMIENTO_Ent> lista = map.BuscarTodosxExperimento(id_experimento);
                map = null;
                return lista;
            }
            public List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodosxRaton(uint id_raton)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                List<BLL_ENT.SEGUIMIENTO_Ent> lista = map.BuscarTodosxRaton(id_raton);
                map = null;
                return lista;
            }

            #endregion

            #region  UPDATE
            public int Actualizar(uint id, uint id_raton, uint id_experimento, DateTime fecha_seguimiento, float peso_raton, float tamano_raton, float a_vol, float b_vol)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                float vol_tumor = CalcularVolumen(a_vol, b_vol);
                int resultado = map.Actualizar(id, id_raton, id_experimento, fecha_seguimiento, peso_raton, tamano_raton, vol_tumor);
                map = null;
                return resultado;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }

            #endregion

		}
	}
	namespace BLL_MAP
	{
		public class SEGUIMIENTO_Map
        {
            #region CREATE
            internal int Agregar(uint id_raton, uint id_experimento, DateTime fecha_seguimiento, float peso_raton, float tamano_raton, float vol_tumor)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "SEGUIMIENTO_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idSeguimiento y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idRaton", SqlDbType.Int);
                Cmd.Parameters["idRaton"].Value = id_raton;

                Cmd.Parameters.Add("idExperimento", SqlDbType.Int);
                Cmd.Parameters["idExperimento"].Value = id_experimento;

                Cmd.Parameters.Add("FechaSeguimiento", SqlDbType.DateTime);
                Cmd.Parameters["FechaSeguimiento"].Value = fecha_seguimiento;

                Cmd.Parameters.Add("PesoRaton", SqlDbType.Float);
                Cmd.Parameters["PesoRaton"].Value = peso_raton;

                Cmd.Parameters.Add("TamanoRaton", SqlDbType.Float);
                Cmd.Parameters["TamanoRaton"].Value = tamano_raton;

                Cmd.Parameters.Add("VolTumor", SqlDbType.Int);
                Cmd.Parameters["VolTumor"].Value = vol_tumor;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region UPDATE
            internal int Actualizar(uint id, uint id_raton, uint id_experimento, DateTime fecha_seguimiento, float peso_raton, float tamano_raton, float vol_tumor)
            {
                throw new NotImplementedException();
            }
            #endregion

            #region READ
            internal BLL_ENT.SEGUIMIENTO_Ent Buscar(uint id)
            {
                throw new NotImplementedException();
            }

            internal List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodos(DateTime fecha_seguimiento)
            {
                throw new NotImplementedException();
            }
            internal List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodosxExperimento(uint id_experimento)
            {
                throw new NotImplementedException();
            }

            internal List<BLL_ENT.SEGUIMIENTO_Ent> BuscarTodosxRaton(uint id_raton)
            {
                throw new NotImplementedException();
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