using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    namespace BLL_Clases
    { 
        public class PAPER_BLL
        { 
            public int AgregarUno(uint id, string titulo, string link, ePUBLICADO publicado=0)
            {
                BLL_Map.PAPER_Map map = new BLL_Map.PAPER_Map();
                int resultado = map.AgregarUno(id, titulo, link, publicado);
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
        }
    }
    namespace BLL_Entidades
    {
        public class PAPER_Ent
        {
            private uint id;
            private string Titulo;
            private string Link;
            private BLL.ePUBLICADO Publicado;
        }

    }
    namespace BLL_Map
    { 
        public class PAPER_Map
        {
            public int AgregarUno(uint id, string titulo, string link, ePUBLICADO publicado = 0)
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
        }
    }
   
}
