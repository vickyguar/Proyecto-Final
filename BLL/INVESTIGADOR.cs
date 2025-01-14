using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_ENT
    {
        public class INVESTIGADOR_Ent
        {
            public uint id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }

            //foreign keys
            public List<uint> idProyecto { get; set; }

            //TODO: Agregué estos dos acá para validar.
            private string Usuario { get; set; }
            private string Contrasena { get; set; } 
            private uint Administrador { get; set; }

            public bool Eliminado { get; set; }
        }
    }
    namespace BLL_CLASS
    {
        public class INVESTIGADOR_Class
        { 
            #region CREATE
            public int Agregar(string nombre, string apellido, string email, string usuario, string contrasena, uint id_proyecto, uint administrador)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                int resultado = map.Agregar(nombre, apellido, email, usuario, contrasena, id_proyecto, administrador);
                map = null;
                return resultado;
            }

            #endregion

            #region READ
            public BLL_ENT.INVESTIGADOR_Ent Buscar(uint id)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                BLL_ENT.INVESTIGADOR_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public BLL_ENT.INVESTIGADOR_Ent BuscarxNombre(string nombre)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                BLL_ENT.INVESTIGADOR_Ent ent = map.BuscarxNombre(nombre);
                map = null;
                return ent;
            }

            public BLL_ENT.INVESTIGADOR_Ent BuscarxApellido(string apellido)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                BLL_ENT.INVESTIGADOR_Ent ent = map.BuscarxApellido(apellido);
                map = null;
                return ent;
            }
            public List<BLL_ENT.INVESTIGADOR_Ent> BuscarTodos()
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                List<BLL_ENT.INVESTIGADOR_Ent> lista = map.BuscarTodos();
                map = null;
                return lista;
            }
#endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre, string apellido, string email, string usuario, string contrasena, uint id_proyecto, uint administrador)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                int resultado = map.Actualizar(id, nombre, apellido, email, usuario, contrasena, id_proyecto, administrador);
                map = null;
                return resultado;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.INVESTIGADOR_Map map = new BLL_MAP.INVESTIGADOR_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }
    namespace BLL_MAP
    {
        public class INVESTIGADOR_Map
        {
            #region CREATE
            public int Agregar(string nombre, string apellido, string email, string usuario, string contrasena, uint id_proyecto, uint administrador)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "INVESTIGADOR_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idDroga y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("Nombre", SqlDbType.VarChar);
                Cmd.Parameters["Nombre"].Value = nombre;

                Cmd.Parameters.Add("Apellido", SqlDbType.VarChar);
                Cmd.Parameters["Apellido"].Value = apellido;

                Cmd.Parameters.Add("Email", SqlDbType.NVarChar,40);
                Cmd.Parameters["Email"].Value = email;

                Cmd.Parameters.Add("Usuario", SqlDbType.VarChar);
                Cmd.Parameters["Usuario"].Value = usuario;

                Cmd.Parameters.Add("Contrasena", SqlDbType.VarChar);
                Cmd.Parameters["Contrasena"].Value = contrasena;

                Cmd.Parameters.Add("Usuario", SqlDbType.VarChar);
                Cmd.Parameters["Usuario"].Value = usuario;

                Cmd.Parameters.Add("idProyecto", SqlDbType.Int);
                Cmd.Parameters["idProyecto"].Value = id_proyecto;

                Cmd.Parameters.Add("Administrador", SqlDbType.Int);
                Cmd.Parameters["Administrador"].Value = administrador;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion
            #region READ
            public BLL_ENT.INVESTIGADOR_Ent Buscar(uint id)
            {
                return null;
            }

            public BLL_ENT.INVESTIGADOR_Ent BuscarxNombre(string nombre)
            {
                return null;
            }

            public BLL_ENT.INVESTIGADOR_Ent BuscarxApellido(string apeliido)
            {
                return null;
            }

            public List<BLL_ENT.INVESTIGADOR_Ent> BuscarTodos()
            {
                return null;
            }

            public List<BLL_ENT.INVESTIGADOR_Ent> BuscarTodos(uint administrador)
            {
                return null;
            }

            #endregion

            #region UPDATE
            public int Actualizar(uint id, string nombre, string apellido, string email, string usuario, string contrasena, uint id_proyecto, uint administrador)
            {
                throw new NotImplementedException();
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                throw new NotImplementedException();
            }

            public int DeshacerBorrar(uint id)
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
}
