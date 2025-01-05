using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//TODO: Resolver acá
// No tiene id porque lo hereda de tratamiento?
// unidad mg/kg en caso de MICELAS

namespace BLL
{
    namespace BLL_Entidades
    {
        public class INYECCION_Ent
        {
            public uint id;
            public sCANTIDAD Dosis; // aca es la dosis mg/kg
            public string Observacion;

            public eADMINISTRACION Administracion;
            public uint id_Droga;
            public uint id_Vehiculo; //TODO: vuela?
            public uint id_Experimento;
            public uint id_Micela;

            public bool Eliminado;
        }

    }
    
    namespace BLL_Clases
    {
        public class INYECCION_BLL : ITRATAMIENTO<BLL_Entidades.INYECCION_Ent>
        {
            int AgregarUno(uint id, sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                int resultado = map.AgregarUno(id, tratamiento, observacion, admin, id_droga, id_vehiculo, id_experimento);
                map = null;
                return resultado;
            }

            int ModificarUno(uint id, sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                int resultado = map.ModificarUno(id, tratamiento, admin, id_droga, id_vehiculo, id_experimento, observacion);
                map = null;
                return resultado;
            }

            public List<BLL_Entidades.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                List<BLL_Entidades.INYECCION_Ent> l = map.BuscarTodosxMicela(id_micela);
                map = null;
                return l;
            }

            #region iMPLEMENTADOS DE INTERFAZ

            public BLL_Entidades.INYECCION_Ent BuscarUno(uint id)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                BLL_Entidades.INYECCION_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public List<BLL_Entidades.INYECCION_Ent> BuscarTodos()
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                List<BLL_Entidades.INYECCION_Ent> l = map.BuscarTodos();
                map = null;
                return l;
            }
            public List<BLL_Entidades.INYECCION_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                List<BLL_Entidades.INYECCION_Ent> l = map.BuscarTodos(id_experimento);
                map = null;
                return l;
            }

            public string[] DevolverDatos(uint id)
            {
                BLL_Entidades.INYECCION_Ent a = this.BuscarUno(id);

                string[] datos = { a.Administracion.ToString(), a.Dosis.ToString(), a.Observacion, "Tratamiento x Inyeccion" };

                // TODO: deberiamos ver como hariamos para devolver info de la droga, vehiculo, experimento correspondiente 

                return datos;
            }

            public int BorrarUno(uint id)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                int resultado = map.BorrarUno(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrarUno(uint id)
            {
                BLL_Map.INYECCION_Map map = new BLL_Map.INYECCION_Map();
                int resultado = map.DeshacerBorrarUno(id);
                map = null;
                return resultado;
            }
            #endregion
        
        }

    }
   
    namespace BLL_Map
    {
        public class INYECCION_Map
        {
            public int AgregarUno(uint id, sCANTIDAD tratamiento, string observacion, eADMINISTRACION admin,  uint id_droga, uint id_vehiculo, uint id_experimento)
            {
                return 1;
            }
            public List<BLL_Entidades.INYECCION_Ent> BuscarTodosxMicela(uint id_micela)
            {
                return null;
            }
            public int ModificarUno(uint id, sCANTIDAD tratamiento, eADMINISTRACION admin, uint id_droga, uint id_vehiculo, uint id_experimento, string observacion) 
            { 
                return 1; 
            }
            public BLL_Entidades.INYECCION_Ent Buscar(uint id)
            { 
                return null;
            }
            public List<BLL_Entidades.INYECCION_Ent> BuscarTodos()
            {
                return null;
            }
            public List<BLL_Entidades.INYECCION_Ent> BuscarTodos(uint id_experimento)
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