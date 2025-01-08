using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// TODO: Clase CIRUGÍA no lleva id por heredarlo?

namespace BLL {

    namespace BLL_Entidades
    {
        public class CIRUGIA_Ent
        {
            public uint id { get; set; }
            public sCANTIDAD PorcentajeExtirpado { get; set; } // aca es la dosis mg/kg
            public DateTime FechaCirugia { get; set; }
            public string Observacion { get; set; }

            public uint id_Experimento { get; set; }

            public bool Eliminado { get; set; }
        }
    }

    namespace BLL_Clases
    {
        public class CIRUGIA_BLL: ITRATAMIENTO<BLL_Entidades.CIRUGIA_Ent>
        {
            int AgregarUno(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                int resultado = map.AgregarUno(id, porcentaje_extirpado, fecha_cirugia, observacion, id_experimento);
                map = null;
                return resultado;
            }
            int ModificarUno(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento, bool eliminado)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                int resultado = map.ModificarUno(id, porcentaje_extirpado, fecha_cirugia, observacion, id_experimento, eliminado);
                map = null;
                return resultado;
            }

            #region iMPLEMENTADOS DE INTERFAZ
            public BLL_Entidades.CIRUGIA_Ent BuscarUno(uint id)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                BLL_Entidades.CIRUGIA_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.CIRUGIA_Ent> BuscarTodos()
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                List<BLL_Entidades.CIRUGIA_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_Entidades.CIRUGIA_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                List<BLL_Entidades.CIRUGIA_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.CIRUGIA_Ent a = this.BuscarUno(id);

                string[] datos = { a.FechaCirugia.ToString(), a.PorcentajeExtirpado.ToString(), a.Observacion, "Cirugia" };

                return datos;
            }

            public int BorrarUno(uint id)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.CIRUGIA_Map map = new BLL_Map.CIRUGIA_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        }

    }

	namespace BLL_Map
    {
        public class CIRUGIA_Map
        {
            public int AgregarUno(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento)
            {
                return 1;
            }
            
            public int ModificarUno(uint id, sCANTIDAD porcentaje_extirpado, DateTime fecha_cirugia, string observacion, uint id_experimento, bool eliminado)
            {
                return 1;
            }
            public BLL_Entidades.CIRUGIA_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_Entidades.CIRUGIA_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_Entidades.CIRUGIA_Ent> BuscarTodos(uint id_experimento)
            {
                return null;
            }
            public int BorrarUno(uint id)
            {
                return 1;
            }
            public int DeshacerBorrarUno(uint id)
            {
                return 1;
            }
        }
    }
	
      
}