using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{ 
    namespace BLL_ENT
    {
        public class PAPER_Ent
        {
            public uint id { get; set; }
            public string Titulo { get; set; }
            public string Link { get; set; }
            public ePUBLICADO Publicado { get; set; }
            public uint idProyecto { get; set; }
            public bool Eliminado { get; set; }
        }

    }
    namespace BLL_CLASS
    {
        public class PAPER_Class
        {
            public int Agregar(string titulo, string link, uint id_proyecto, ePUBLICADO publicado = 0)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                int resultado = map.Agregar(titulo, link, id_proyecto, publicado);
                map = null;
                return resultado;
            }
            public BLL_ENT.PAPER_Ent Buscar(uint id)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                BLL_ENT.PAPER_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }

            public BLL_ENT.PAPER_Ent Buscar(string titulo)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                BLL_ENT.PAPER_Ent ent = map.Buscar(titulo);
                // no deberia haber +1 con = titulo

                map = null;
                return ent;
            }

            public List<BLL_ENT.PAPER_Ent> BuscarTodos()
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                List<BLL_ENT.PAPER_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }

            public List<BLL_ENT.PAPER_Ent> BuscarTodos(uint id_proyecto)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                List<BLL_ENT.PAPER_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }

            public List<BLL_ENT.PAPER_Ent> BuscarTodos(ePUBLICADO publicado)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                List<BLL_ENT.PAPER_Ent> l = map.BuscarTodos(publicado);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL.BLL_ENT.PAPER_Ent a = this.Buscar(id);
                string[] datos = { a.Titulo, a.Link, a.Publicado.ToString(), a.Eliminado.ToString(), "Paper" };
                return datos;
            }

            public int Actualizar(int id, string titulo, uint id_proyecto, string link, uint publicado)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                int resultado = map.Actualizar(id, titulo, id_proyecto, link, publicado);
                map = null;
                return resultado;
            }

            public int Borrar(int id)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(int id)
            {
                BLL_MAP.PAPER_Map map = new BLL_MAP.PAPER_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }
        }
    }
    namespace BLL_MAP
    { 
        public class PAPER_Map
        {
            public int Agregar(string titulo, string link, uint id_proyecto, ePUBLICADO publicado)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "PAPER_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idPaper y Eliminado en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idProyecto", SqlDbType.Int);
                Cmd.Parameters["idProyecto"].Value = id_proyecto;

                Cmd.Parameters.Add("Titulo", SqlDbType.VarChar);
                Cmd.Parameters["Titulo"].Value = titulo;
                //var char es hasta 200

                Cmd.Parameters.Add("Link", SqlDbType.VarChar);
                Cmd.Parameters["Link"].Value = link;

                Cmd.Parameters.Add("Publicado", SqlDbType.Int);
                Cmd.Parameters["Publicado"].Value = publicado;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            public BLL_ENT.PAPER_Ent Buscar(uint id)
            {
                return null;
            }
            public BLL_ENT.PAPER_Ent Buscar(string titulo)
            {
                return null;
            }
            public List<BLL_ENT.PAPER_Ent> BuscarTodos()
            {
                return null;
            }

            public List<BLL_ENT.PAPER_Ent> BuscarTodos(uint id_proyecto)
            {
                return null;
            }
            public List<BLL_ENT.PAPER_Ent> BuscarTodos(ePUBLICADO publicado)
            {
                return null;
            }
            public int Actualizar(int id, string titulo, uint id_proyecto, string link, uint publicado)
            {
                return 1;
            }

            public int Borrar(int id)
            {
                return 1;
            }
            public int DeshacerBorrar(int id)
            {
                return 1;
            }
        }
    }
   
}
