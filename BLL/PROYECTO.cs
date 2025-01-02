using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

// TODO: Proyecto no estaba relacionado con experimento.
namespace BLL 
{
    namespace BLL_CLASS
    {
        public class PROYECTO_CLASS
        {
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(uint id)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                BLL_ENTITY.PROYECTO_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos()
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                List<BLL_ENTITY.PROYECTO_ENT> lista = map.BuscarTodos();
                map = null;
                return lista;
            }

            // public int DeshacerBorrarUno(uint id)
            // public int AgregarUno(uint id, string nombre)
            // public int ModificarUno(uint id, string nombre)
        }
    }

    namespace BLL_ENTITY
    {
        public class PROYECTO_ENT
        {
            public string Titulo { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public eESTADO Estado { get; set; }
            public uint id { get; set; }
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        class PROYECTO_MAP
        {
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(uint id)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();
                cmd.CommandText = "PROYECTO_BuscarUno";// Nombre del SP → SELECT * FROM PROYECTO WHERE id = @id;
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
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debe ser único)
                if (lista.Count > 0) return lista[0];
                else return null;
            }

            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos()
            {
                // Instancio la capa DAL y se abro una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PROYECTO_BuscarTodos";// Nombre del SP → SELECT * FROM PROYECTO;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                // Ejecuto el SP y obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorno la lista
                if (lista.Count > 0) return lista;
                else return null;
            }

            private List<BLL_ENTITY.PROYECTO_ENT> CastDataToEntity(DataTable dt)
            {
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();

                // Itero sobre cada fila de la DataTable
                foreach (DataRow dr in dt.Rows)
                {
                    // Si el id es distinto de null
                    if (dr["id"].ToString() != null)
                    {
                        // Nueva instancia de PROYECTO_ENT
                        BLL_ENTITY.PROYECTO_ENT ent = new BLL_ENTITY.PROYECTO_ENT();

                        // Mapeo de atributos 
                        ent.id = uint.Parse(dr["id"].ToString());
                        ent.Titulo = dr["Titulo"].ToString();
                        ent.Estado = (eESTADO)Enum.Parse(typeof(eESTADO), dr["Estado"].ToString());
                        ent.FechaInicio = DateTime.Parse(dr["FechaInicio"].ToString());
                        ent.FechaFin = DateTime.Parse(dr["FechaFin"].ToString());
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
