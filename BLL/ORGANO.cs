using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BLL.BLL_CLASS;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    namespace BLL_CLASS
    {
        public class ORGANO_Class : BLL_CLASS.IMUESTRA<BLL_ENT.ORGANO_Ent>
        {
            #region CREATE
            // TODO: ver si es posible (lo mismo aplica en todas las clases para hacer el 'Agregar')
            //      - el id no se lo paso porque quizás se pueda tildar autoincremental
            //      - el deleted no se lo paso porque porque quizás se pueda tildar default value 0
            //      - id_nombre_muestra debería morir
            public int Agregar(uint id_nombre_muestra, uint id_nombre_tecnica, uint id_raton, DateTime fecha_muestra, string num_histopato, uint num_vasos, float peso_tumor, uint eliminado)
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                int resultado = map.Agregar(id_nombre_muestra, id_nombre_tecnica, id_raton, fecha_muestra, num_histopato, num_vasos, peso_tumor, eliminado);
                map = null;
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.ORGANO_Ent Buscar(uint id)
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                BLL_ENT.ORGANO_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENT.ORGANO_Ent> BuscarTodos()
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                List<BLL_ENT.ORGANO_Ent> lista = map.BuscarTodos();
                map = null;
                return lista;
            }
            public List<BLL_ENT.ORGANO_Ent> BuscarTodos(uint id_raton)
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                List<BLL_ENT.ORGANO_Ent> lista = map.BuscarTodos();
                map = null;
                return lista;
            }
            #endregion

            // TODO: update

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.ORGANO_Map map = new BLL_MAP.ORGANO_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion

            public string[] DevolverDatos(uint id)
            {
                BLL.BLL_ENT.ORGANO_Ent tumor = this.Buscar(id);
                string[] datos = {
                    tumor.id.ToString(),
                    tumor.idNombreMuestra.ToString(),
                    tumor.idNombreTecnica.ToString(),
                    tumor.idRaton.ToString(),
                    tumor.FechaMuestra.ToString(),
                    tumor.NumHistopato.ToString(),
                    tumor.PesoOrgano.ToString(),
                    tumor.Metastasis.ToString(),
                    tumor.Observación.ToString(),
                    tumor.Eliminado.ToString(),
                    "Organo" };
                return datos;
            }

        }
    }

    namespace BLL_ENT
    {
        public class ORGANO_Ent
        {
            public uint id { get; set; }
            public uint idNombreMuestra { get; set; } // FK → TODO: ELIMINAR → En el formato que tendría ahora, esto no hace falta
            public uint idNombreTecnica { get; set; } // FK → TODO: siento que esta FK se puede agregar después de ser creada
            public uint idRaton { get; set; } // FK
            public DateTime FechaMuestra { get; set; }
            public string Observación { get; set; } // TODO: da agregar observación?
            public uint Eliminado { get; set; }

            /* --- Propias de Organo --- */
            public string NumHistopato { get; set; }
            public uint Metastasis { get; set; }
            public float PesoOrgano { get; set; }
            /* ------------------------ */
        }
    }

    namespace BLL_MAP
    {
        public class ORGANO_Map
        {
            #region CREATE
            public int Agregar(uint id_nombre_muestra, uint id_nombre_tecnica, uint id_raton, DateTime fecha_muestra, string num_histopato, uint num_vasos, float peso_tumor, uint eliminado)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "ORGANO_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Connection = Conn;
                /* ACA AGREGAR TODOS LOS PARAMETROS ...
                Cmd.Parameters.Add("id_nombre_muestra", SqlDbType.VarChar, 200); //TODO: chequear longitud
                Cmd.Parameters["idNombreMuestra"].Value = id_nombre_muestra;
                */

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.ORGANO_Ent Buscar(uint id)
            {
                // Instancio la capa DAL y se abre una conexión a la BD (UCA)
                DAL.sqlServer sql = new DAL.sqlServer();
                SqlConnection conn = new SqlConnection();
                conn = sql.AbrirConexion(conn);

                // Procedimiento almacenado (SP)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ORGANO_BuscarUno";// Nombre del SP → SELECT * FROM TUMOR WHERE id = @id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add("id", SqlDbType.Int); // TODO: chequear tipo de dato
                cmd.Parameters["id"].Value = id;

                // Ejecuto el SP y se obtengo la DataTable
                DataTable dt = sql.EjecutarSQL_DT(cmd);
                sql.CerrarConexion(conn); // Cierro conexión

                // Casteo la DataTable a una lista de PROYECTO_ENT
                List<BLL_ENT.ORGANO_Ent> lista = new List<BLL_ENT.ORGANO_Ent>();
                lista = CastDataToEntity(dt);

                // Retorna el elemento encontrado (que debería ser único)
                if (lista.Count > 0) return lista[0];
                else return null;
            }
            public List<BLL_ENT.ORGANO_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENT.ORGANO_Ent> BuscarTodos(uint id_raton)
            {
                return null;
            }
            #endregion

            // TODO: update

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

            private List<BLL_ENT.ORGANO_Ent> CastDataToEntity(DataTable dt)
            {
                List<BLL_ENT.ORGANO_Ent> lista = new List<BLL_ENT.ORGANO_Ent>();

                // Itero sobre cada fila de la DataTable
                foreach (DataRow dr in dt.Rows)
                {
                    // Si el id es distinto de null
                    if (dr["id"].ToString() != null)
                    {
                        // Nueva instancia de PROYECTO_ENT
                        BLL_ENT.ORGANO_Ent ent = new BLL_ENT.ORGANO_Ent();

                        // Mapeo de atributos 
                        ent.id = uint.Parse(dr["id"].ToString());
                        ent.idNombreMuestra = uint.Parse(dr["idNombreMuestra"].ToString());
                        ent.idNombreTecnica = uint.Parse(dr["idNombreTecnica"].ToString());
                        ent.idRaton = uint.Parse(dr["idRaton"].ToString());
                        ent.FechaMuestra = DateTime.Parse(dr["FechaMuestra"].ToString());
                        ent.NumHistopato = dr["NumHistopato"].ToString();
                        ent.Metastasis = uint.Parse(dr["NumVasos"].ToString());
                        ent.PesoOrgano = float.Parse(dr["PesoTumor"].ToString());
                        ent.Observación = dr["Observacion"].ToString();
                        ent.Eliminado = uint.Parse(dr["Eliminado"].ToString());

                        // Agrego la entidad a la lista
                        lista.Add(ent);
                    }
                }
                return lista;
            }

        }
    }
}