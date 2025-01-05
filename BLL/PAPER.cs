using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{ 
    namespace BLL_Entidades
    {
        public class PAPER_Ent
        {
            public uint id { get; set; }
            public string Titulo { get; set; }
            public string Link { get; set; }
            public ePUBLICADO Publicado { get; set; }
            public bool Eliminado { get; set; }
        }

    }
    namespace BLL_Clases
    {
        public class PAPER_BLL
        {
            public int AgregarUno(uint id, string titulo, string link, ePUBLICADO publicado = 0, bool eliminado=false)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                int resultado = map.AgregarUno(id, titulo, link, publicado, eliminado);
                map = null;
                return resultado;
            }
            public BLL_Entidades.PAPER_Ent BuscarUno(uint id)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                BLL_Entidades.PAPER_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }

            public BLL_Entidades.PAPER_Ent BuscarUno(string titulo)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                BLL_Entidades.PAPER_Ent ent = map.Buscar(titulo);
                // no deberia haber +1 con = titulo

                map = null;
                return ent;
            }

            public List<BLL_Entidades.PAPER_Ent> BuscarTodos()
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                List<BLL_Entidades.PAPER_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }

            public List<BLL_Entidades.PAPER_Ent> BuscarTodos(uint id_proyecto)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                List<BLL_Entidades.PAPER_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }

            public List<BLL_Entidades.PAPER_Ent> BuscarTodos(ePUBLICADO publicado)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                List<BLL_Entidades.PAPER_Ent> l = map.BuscarTodos(publicado);
                map = null;
                return l;
            }
            public string[] DevolverDatos(uint id)
            {
                BLL.BLL_Entidades.PAPER_Ent a = this.BuscarUno(id);
                string[] datos = { a.Titulo, a.Link, a.Publicado.ToString(), a.Eliminado.ToString(), "Paper" };
                return datos;
            }

            public int ModificarUno(int id, string titulo, string link, uint publicado)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                int resultado = map.ModificarUno(id, titulo, link, publicado);
                map = null;
                return resultado;
            }

            public int BorrarUno(int id)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(int id)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
        }
    }
    namespace BLL_Map
    { 
        public class PAPER_Map
        {
            public int AgregarUno(uint id, string titulo, string link, ePUBLICADO publicado, bool eliminado)
            {
                return 1;
            }
            public BLL_Entidades.PAPER_Ent Buscar(uint id)
            {
                return null;
            }
            public BLL_Entidades.PAPER_Ent Buscar(string titulo)
            {
                return null;
            }
            public List<BLL_Entidades.PAPER_Ent> BuscarTodos()
            {
                return null;
            }

            public List<BLL_Entidades.PAPER_Ent> BuscarTodos(uint id_proyecto)
            {
                return null;
            }
            public List<BLL_Entidades.PAPER_Ent> BuscarTodos(ePUBLICADO publicado)
            {
                return null;
            }
            public int ModificarUno(int id, string titulo, string link, uint publicado)
            {
                return 1;
            }

            public int BorrarUno(int id)
            {
                return 1;
            }
            public int DeshacerBorrarUno(int id)
            {
                return 1;
            }
        }
    }
   
}
