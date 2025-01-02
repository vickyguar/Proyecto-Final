using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class TRATAMIENTO {
        
        private uint id;
        private string Observacion;
        private sCANTIDAD Tratamiento;

        private List<RATON> Ratones;

        #region FUNCIONES p LISTAS
        public void Agg(RATON rat) {
            Ratones.Add(rat);
            return;
        }

        // TODO: Quitar de tablas

        public List<RATON> BuscarRaton() {
            return Ratones;
        }

        public RATON BuscarRaton(uint idRat) {
            RATON MiRaton = new RATON();
            MiRaton = Ratones.Find(x => x.GetId() == idRat);
            return MiRaton;
        }
        #endregion

        #region GETTERS & SETTERS
        public uint GetId() {  return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetObservacion() {  return Observacion; }
        public void SetObservacion(string observacion) { Observacion = observacion; return; }
        public sCANTIDAD GetTratamiento() { return Tratamiento; }
        public void SetTratamiento(sCANTIDAD tratamiento) { Tratamiento = tratamiento; return; }
        #endregion

        public TRATAMIENTO() {
            Ratones = new List<RATON>();
        }
    }
}
