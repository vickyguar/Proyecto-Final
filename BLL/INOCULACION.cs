using System;
using System.Collections.Generic;
using System.Text;
// TODO: resolver sCantidad → private sCANTIDAD Cantidad;
// TODO: qué era TipoInoculacion que siempre me olvido? Dejemos comentado

namespace BLL {
    public class INOCULACION {
        private uint id;
        private DateTime FechaInoculacion;
        private eADMINISTRACION Administracion;
        private string TipoInoculacion;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public DateTime GetFechaInoculacion() {  return FechaInoculacion; }
        public void SetFechaInoculacion(DateTime fechita) { FechaInoculacion = fechita; return; }
        public eADMINISTRACION GetAdministracion() { return Administracion; }
        public void SetAdministracion(eADMINISTRACION administracion) { Administracion = administracion; return; }
        // public string GetTipoInoculacion() { return TipoInoculacion;}
        //public void SetTipoInoculacion(string tipo) { TipoInoculacion= tipo; return; }
        #endregion

        public INOCULACION() { 
        
        }
    }
}
