using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    namespace BLL_ENTITY
    {
        public class INYECCION_Ent
        {
            public uint id { get; set; }
            public sCANTIDAD Dosis { get; set; } // aca es la dosis mg/kg
            public string Observacion { get; set; }

            public eADMINISTRACION Administracion { get; set; }
            public sCANTIDAD PeriodoTratamiento { get; set; }
            public uint idDroga { get; set; }
            public uint idVehiculo { get; set; } //TODO: vuela?
            public uint idExperimento { get; set; }
            public uint idMicela { get; set; }

            public bool Eliminado { get; set; }
        }

    }
    
    namespace BLL_CLASS
    {
        public class INYECCION_BLL : ITRATAMIENTO<BLL_ENTITY.INYECCION_Ent>
        {
            int Agregar(sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.Agregar(tratamiento, observacion, admin, id_droga, id_vehiculo, id_experimento);
                map = null;
                return resultado;
            }

            int ModificarUno(uint id, sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.ModificarUno(id, tratamiento, admin, id_droga, id_vehiculo, id_experimento, observacion);
                map = null;
                return resultado;
            }

            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENTITY.INYECCION_Ent> l = map.BuscarTodosxMicela(id_micela);
                map = null;
                return l;
            }

            #region iMPLEMENTADOS DE INTERFAZ

            public BLL_ENTITY.INYECCION_Ent Buscar(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                BLL_ENTITY.INYECCION_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodos()
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENTITY.INYECCION_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                List<BLL_ENTITY.INYECCION_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_ENTITY.INYECCION_Ent a = this.Buscar(id);

                string[] datos = { a.Administracion.ToString(), a.Dosis.ToString(), a.Observacion, "Tratamiento x Inyeccion" };

                // TODO: deberiamos ver como hariamos para devolver info de la droga, vehiculo, experimento correspondiente 

                return datos;
            }

            public int BorrarUno(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_MAP.INYECCION_Map map = new BLL_MAP.INYECCION_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        
        }

    }
   
    namespace BLL_MAP
    {
        public class INYECCION_Map
        {
            public int Agregar(sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin,  uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                return 1;
            }
            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                return null;
            }
            public int ModificarUno(uint id, sCANTIDAD tratamiento, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento, string observacion) 
            { 
                return 1; 
            }
            public BLL_ENTITY.INYECCION_Ent Buscar(uint id)
            { 
                return null;
            }
            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_ENTITY.INYECCION_Ent> BuscarTodos(uint id_experimento)
            {
                return null;
            }
            public int BorrarUno(uint id) {
                return 1;
            }

            public int DeshacerBorrarUno(uint id) {
                return 1; 
            }

        }
    }
}