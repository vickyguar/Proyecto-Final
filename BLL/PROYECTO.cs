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
            // CREATE 
            // TODO: ver si es posible (lo mismo aplica en todas las clases para hacer el 'Agregar')
            //      - el id no se lo paso porque quizás se pueda tildar autoincremental
            //      - el deleted no se lo paso porque porque quizás se pueda tildar default value 0
            //      - el Estado no se lo paso porque quizás se pueda tildar default value 0
            public int Agregar(string Titulo, string Tema, DateTime FechaInicio, DateTime FechaFin, eESTADO Estado)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                int resultado = map.Agregar(Titulo, Tema, FechaInicio, FechaFin, Estado);
                map = null;
                return resultado;
            }

            // READ
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(uint id)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                BLL_ENTITY.PROYECTO_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(string Titulo)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                BLL_ENTITY.PROYECTO_ENT ent = map.BuscarUno(Titulo);
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
            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos(string Tema)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                List<BLL_ENTITY.PROYECTO_ENT> lista = map.BuscarTodos(Tema);
                map = null;
                return lista;
            }
            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos(eESTADO Estado)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                List<BLL_ENTITY.PROYECTO_ENT> lista = map.BuscarTodos(Estado);
                map = null;
                return lista;
            }

            //TODO: Buscar por FechaInicio y FechaFin

            // UPDATE
            public int Actualizar(uint id, string Titulo, string Tema, DateTime FechaInicio, DateTime FechaFin, eESTADO Estado)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                int resultado = map.Actualizar(id, Titulo, Tema, FechaInicio, FechaFin, Estado);
                map = null;
                return resultado;
            }

            // DELETE
            public int Eliminar(uint id, uint deleted)
            {
                BLL_MAP.PROYECTO_MAP map = new BLL_MAP.PROYECTO_MAP();
                int resultado = map.Eliminar(id, deleted);
                map = null;
                return resultado;
            }

        }
    }

    namespace BLL_ENTITY
    {
        public class PROYECTO_ENT
        {
            public string Titulo { get; set; }
            public string Tema { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public eESTADO Estado { get; set; }
            public uint id { get; set; }
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        public class PROYECTO_MAP
        {
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(uint id)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PROYECTO_BuscarUno";// Nombre del SP → SELECT * FROM PROYECTO WHERE id = @id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add("id", SqlDbType.Int); // TODO: chequear tipo de dato
                cmd.Parameters["id"].Value = id;

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debería ser único)
                if (lista.Count > 0) return lista[0];
                else return null;
            }
            public BLL_ENTITY.PROYECTO_ENT BuscarUno(string Titulo)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PROYECTO_BuscarUnoPorTitulo";// Nombre del SP → SELECT * FROM PROYECTO WHERE Titulo = @Titulo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add("Titulo", SqlDbType.VarChar, 200); // TODO: chequear tipo de dato
                cmd.Parameters["Titulo"].Value = Titulo;

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debería ser único)
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
            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos(string Tema)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PROYECTO_BuscarPorTema";// Nombre del SP → SELECT * FROM PROYECTO WHERE Tema = @Tema;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add("Tema", SqlDbType.VarChar, 200); // TODO: chequear tipo de dato
                cmd.Parameters["Tema"].Value = Tema;

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debe ser único)
                if (lista.Count > 0) return lista;
                else return null;
            }
            public List<BLL_ENTITY.PROYECTO_ENT> BuscarTodos(eESTADO Estado)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PROYECTO_BuscarPorEstado";// Nombre del SP → SELECT * FROM PROYECTO WHERE Estado = @Estado;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add("Estado", SqlDbType.Int);
                cmd.Parameters["Estado"].Value = Estado;

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENTITY.PROYECTO_ENT> lista = new List<BLL_ENTITY.PROYECTO_ENT>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debe ser único)
                if (lista.Count > 0) return lista;
                else return null;
            }
            public int Actualizar(uint id, string Titulo, string Tema, DateTime FechaInicio, DateTime FechaFin, eESTADO Estado)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "PROYECTO_Actualizar";
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Connection = Conn;
                Cmd.Parameters.Add("id", SqlDbType.Int);
                Cmd.Parameters["id"].Value = id;
                Cmd.Parameters.Add("Titulo", SqlDbType.VarChar, 200);
                Cmd.Parameters["Titulo"].Value = Titulo;
                Cmd.Parameters.Add("Tema", SqlDbType.VarChar, 200);
                Cmd.Parameters["Tema"].Value = Tema;
                Cmd.Parameters.Add("FechaInicio", SqlDbType.DateTime);
                Cmd.Parameters["FechaInicio"].Value = FechaInicio;
                Cmd.Parameters.Add("FechaFin", SqlDbType.DateTime);
                Cmd.Parameters["FechaFin"].Value = FechaFin;
                Cmd.Parameters.Add("Estado", SqlDbType.Int);
                Cmd.Parameters["Estado"].Value = Estado;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            public int Eliminar(uint id, uint deleted)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "PROYECTO_Eliminar";
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Connection = Conn;
                Cmd.Parameters.Add("id", SqlDbType.Int);
                Cmd.Parameters["id"].Value = id;
                Cmd.Parameters.Add("deleted", SqlDbType.Int);
                Cmd.Parameters["deleted"].Value = deleted;


                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
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
                        ent.Tema = dr["Tema"].ToString();
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
