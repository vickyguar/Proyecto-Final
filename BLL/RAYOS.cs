using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	namespace BLL_Entidades
    {
        public class RAYOS_Ent
        {
            public uint Sesiones;
            public sCANTIDAD TasaDosis; //velocidad con la que se entrego
            public sCANTIDAD DosisTotal;
            public sCANTIDAD EnergiaRX;

            public string Observacion;
            public uint id_Experimento;
            public bool Eliminado;
        }
    }

	namespace BLL_Clases
    {
        public class RAYOS_BLL: ITRATAMIENTO<BLL_Entidades.RAYOS_Ent>
        {
            public int AgregarUno(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                int resultado = map.AgregarUno(id, tasa_dosis, dosis_total, energiaRX, observacion, id_experimento);
                map = null;
                return resultado;
            }
            public int ModificarUno(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento, bool eliminado)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                int resultado = map.ModificarUno(id, tasa_dosis, dosis_total, energiaRX, observacion, id_experimento, eliminado);
                map = null;
                return resultado;
            }

            #region iMPLEMENTADOS DE INTERFAZ
            public BLL_Entidades.RAYOS_Ent BuscarUno(uint id)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                BLL_Entidades.RAYOS_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.RAYOS_Ent> BuscarTodos()
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                List<BLL_Entidades.RAYOS_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_Entidades.RAYOS_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                List<BLL_Entidades.RAYOS_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.RAYOS_Ent a = this.BuscarUno(id);

                string[] datos = { a.DosisTotal.ToString(), a.EnergiaRX.ToString(), a.TasaDosis.ToString(), a.Observacion, "TRATAMIENTO x RAYOS" };

                return datos;
            }

            public int BorrarUno(uint id)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.RAYOS_Map map = new BLL_Map.RAYOS_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion

        }
    }

	namespace BLL_Map
    {
        public class RAYOS_Map
        {
            public int ModificarUno(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento, bool eliminado)
            {
                return 1;
            }

            public int AgregarUno(uint id, sCANTIDAD tasa_dosis, sCANTIDAD dosis_total, sCANTIDAD energiaRX, string observacion, uint id_experimento)
            {
                return 1;
            }
            public BLL_Entidades.RAYOS_Ent Buscar(uint id)
            {
                return null;
            }
            public List<BLL_Entidades.RAYOS_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_Entidades.RAYOS_Ent> BuscarTodos(uint id_experimento)
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