using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

/*namespace BLL {
    namespace BLL_CLASS
    {
        public class CELULA_CLASS : INOCULACION
        {
            public BLL_ENTITY.CELULA_ENT BuscarUno(uint id)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                BLL_ENTITY.CELULA_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }

            public BLL_ENTITY.CARCINOGENO_ENT BuscarUno(uint id)
            {
                BLL_MAP.CARCINOGENO_MAP map = new BLL_MAP.CARCINOGENO_MAP();
                BLL_ENTITY.CARCINOGENO_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }

        }
    }

    namespace BLL_ENTITY
    {
        public class CELULA_ENT
        {
            public uint id { get; set; }
            public uint CantidadCelulas { get; set; }
            public uint LineaCelular { get; set; }
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        class CELULA_MAP
        {
            public BLL_ENTITY.CELULA_ENT BuscarUno(uint id)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();
                cmd.CommandText = "CARCINOGENO_BuscarUno";// Nombre del SP → SELECT * FROM CELULA_ENT WHERE id = @id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                param.Value = id;
                param.DbType = DbType.UInt32;
                param.ParameterName = "ID";
                cmd.Parameters.Add(param);

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de CELULA_ENT
                List<BLL_ENTITY.CELULA_ENT> lista = new List<BLL_ENTITY.CELULA_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debe ser único)
                if (lista.Count > 0) return lista[0];
                else return null;
            }
            public List<BLL_ENTITY.CELULA_ENT> BuscarTodos()
            {
                // Instancio la capa DAL y se abro una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "CELULA_BuscarTodos";// Nombre del SP → SELECT * FROM CELULA_ENT;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                // Ejecuto el SP y obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de CELULA_ENT
                List<BLL_ENTITY.CELULA_ENT> lista = new List<BLL_ENTITY.CELULA_ENT>();
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
                cmd.CommandText = "CELULA_BorrarUno";// Nombre del SP → UPDATE CELULA_ENT SET deleted = true WHERE id = @id;
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
            private List<BLL_ENTITY.CELULA_ENT> CastDataToEntity(DataTable dt)
            {
                List<BLL_ENTITY.CELULA_ENT> lista = new List<BLL_ENTITY.CELULA_ENT>();

                // Itero sobre cada fila de la DataTable
                foreach (DataRow dr in dt.Rows)
                {
                    // Si el id es distinto de null
                    if (dr["id"].ToString() != null)
                    {
                        // Nueva instancia de CELULA_ENT
                        BLL_ENTITY.CELULA_ENT ent = new BLL_ENTITY.CELULA_ENT();

                        // Mapeo de atributos 
                        ent.id = uint.Parse(dr["id"].ToString());
                        ent.Nombre = dr["Nombre"].ToString();
                        ent.deleted = bool.Parse(dr["deleted"].ToString());

                        // Agrego la entidad a la lista
                        lista.Add(ent);
                    }
                }
                return lista;
            }
        }
    }
   
}*/