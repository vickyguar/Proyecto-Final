using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{

    namespace BLL_CLASS
    {
        public class EXPERIMENTO_CLASS
        {
            // CREATE
            // TODO: ver si es posible (lo mismo aplica en todas las clases para hacer el 'Agregar')
            //      - el id no se lo paso porque quizás se pueda tildar autoincremental
            //      - el deleted no se lo paso porque porque quizás se pueda tildar default value 0
            //      - el Estado no se lo paso porque quizás se pueda tildar default value 0
            //      - el idProyecto, habría que asignarlo acá? → Yo creo que sí (Vicky)
            public int Agregar(uint idProyecto, string Titulo, DateTime FechaInicio, DateTime FechaFin, eESTADO Estado)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                int resultado = map.Agregar(idProyecto, Titulo, FechaInicio, FechaFin, Estado);
                map = null;
                return resultado;
            }

            // READ
            public BLL_ENTITY.EXPERIMENTO_ENT BuscarUno(uint id)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                BLL_ENTITY.EXPERIMENTO_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }
            public BLL_ENTITY.EXPERIMENTO_ENT BuscarUno(string Titulo)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                BLL_ENTITY.EXPERIMENTO_ENT ent = map.BuscarUno(Titulo);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.EXPERIMENTO_ENT> BuscarTodos()
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                List<BLL_ENTITY.EXPERIMENTO_ENT> lista = map.BuscarTodos();
                map = null;
                return lista;
            }
            public List<BLL_ENTITY.EXPERIMENTO_ENT> BuscarTodos(string Tema)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                List<BLL_ENTITY.EXPERIMENTO_ENT> lista = map.BuscarTodos(Tema);
                map = null;
                return lista;
            }
            public List<BLL_ENTITY.EXPERIMENTO_ENT> BuscarTodos(eESTADO Estado)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                List<BLL_ENTITY.EXPERIMENTO_ENT> lista = map.BuscarTodos(Estado);
                map = null;
                return lista;
            }

            //TODO: Buscar por FechaInicio y FechaFin

            // UPDATE
            public int Actualizar(uint id, string Titulo, string Tema, DateTime FechaInicio, DateTime FechaFin, eESTADO Estado)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                int resultado = map.Actualizar(id, Titulo, Tema, FechaInicio, FechaFin, Estado);
                map = null;
                return resultado;
            }

            // DELETE
            public int Eliminar(uint id, uint deleted)
            {
                BLL_MAP.EXPERIMENTO_MAP map = new BLL_MAP.EXPERIMENTO_MAP();
                int resultado = map.Eliminar(id, deleted);
                map = null;
                return resultado;
            }


        }
    }
    namespace BLL_ENTITY
    {
        // Aca deje un comentario
        public class EXPERIMENTO_ENT
        {
            public string Titulo { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public eESTADO Estado { get; set; }
            public uint id { get; set; }
            public uint idProyecto { get; set; } // FKO
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        public class EXPERIMENTO_MAP { 

        }
    }
}
