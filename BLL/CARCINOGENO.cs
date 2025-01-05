using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
//TODO: esto será una tabla nomás?

namespace BLL
{

    namespace BLL_CLASS
    {
        //TODO: agregar que carcinogeno hereda de inoculacion
        public class CARCINOGENO_CLASS
        {
            public BLL_ENTITY.CARCINOGENO_ENT BuscarUno(uint id)
            {
                BLL_MAP.CARCINOGENO_MAP map = new BLL_MAP.CARCINOGENO_MAP();
                BLL_ENTITY.CARCINOGENO_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.CARCINOGENO_ENT> BuscarTodos()
            {
                BLL_MAP.CARCINOGENO_MAP map = new BLL_MAP.CARCINOGENO_MAP();
                List<BLL_ENTITY.CARCINOGENO_ENT> lista = map.BuscarTodos();
                map = null;
                return lista;
            }
            public int BorrarUno(uint id)
            {
                BLL_MAP.CARCINOGENO_MAP map = new BLL_MAP.CARCINOGENO_MAP();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }

            // public int DeshacerBorrarUno(uint id)
            // public int AgregarUno(uint id, string nombre)
            // public int ModificarUno(uint id, string nombre)
        }
    }

    namespace BLL_ENTITY
    {
        public class CARCINOGENO_ENT
        {
            public string Nombre { get; set; }
            public uint id { get; set; }
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        class CARCINOGENO_MAP
        {
            public BLL_ENTITY.CARCINOGENO_ENT BuscarUno(uint id)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();
                cmd.CommandText = "CARCINOGENO_BuscarUno";// Nombre del SP → SELECT * FROM CARCINOGENO WHERE id = @id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                param.Value = id;
                param.DbType = DbType.UInt32;
                param.ParameterName = "ID";
                cmd.Parameters.Add(param);

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de CARCINOGENO_ENT
                List<BLL_ENTITY.CARCINOGENO_ENT> lista = new List<BLL_ENTITY.CARCINOGENO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debe ser único)
                if (lista.Count > 0) return lista[0];
                else return null;
            }
            public List<BLL_ENTITY.CARCINOGENO_ENT> BuscarTodos()
            {
                // Instancio la capa DAL y se abro una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "CARCINOGENO_BuscarTodos";// Nombre del SP → SELECT * FROM CARCINOGENO;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                // Ejecuto el SP y obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de CARCINOGENO_ENT
                List<BLL_ENTITY.CARCINOGENO_ENT> lista = new List<BLL_ENTITY.CARCINOGENO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorno la lista
                if (lista.Count > 0) return lista;
                else return null;
            }
            public int BorrarUno(uint id)
            {
                // Instancio la capa DAL y se abro una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();
                cmd.CommandText = "CARCINOGENO_BorrarUno";// Nombre del SP → UPDATE CARCINOGENO SET deleted = true WHERE id = @id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                param.Value = id;
                param.DbType = DbType.UInt32;
                param.ParameterName = "ID";
                cmd.Parameters.Add(param);

                // Ejecuto el SP y obtengo la DataTable
                int resultado = sql.EjecutarSQL_Int(cmd);
                sql.CerrarConexion(conn); // Cierro conexión
                return resultado;
            }
            private List<BLL_ENTITY.CARCINOGENO_ENT> CastDataToEntity(DataTable dt)
            {
                List<BLL_ENTITY.CARCINOGENO_ENT> lista = new List<BLL_ENTITY.CARCINOGENO_ENT>();

                // Itero sobre cada fila de la DataTable
                foreach (DataRow dr in dt.Rows)
                {
                    // Si el id es distinto de null
                    if (dr["id"].ToString() != null)
                    {
                        // Nueva instancia de CARCINOGENO_ENT
                        BLL_ENTITY.CARCINOGENO_ENT ent = new BLL_ENTITY.CARCINOGENO_ENT();

                        // Mapeo de atributos 
                        ent.id = uint.Parse(dr["id"].ToString());
                        ent.Nombre = dr["Nombre"].ToString();
                        ent.deleted = uint.Parse(dr["deleted"].ToString());

                        // Agrego la entidad a la lista
                        lista.Add(ent);
                    }
                }
                return lista;
            }
        }
    }
}
