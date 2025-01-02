using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	public class RESULTADO {

        private uint id;
        private DateTime FechaResultado;
        private sCANTIDAD Resultado;
        private string Observacion;
		//private int TipoResultado; // TODO: documentar, qué era esto? perdon por mi déficit de atención. Sera enum o otra tabla? NO ESTAN HECHOS LOS G&S
		public EQUIPO Equipo;
		public TECNICA Tecnica; // TODO: era el nombre de la profesional, no? vuela?

        #region GETTERS & SETTERS
        public uint GetId() {  return id; }
		public void SetId(uint _id) { id = _id; return; }
		public DateTime GetFechaResultado() { return FechaResultado; }
		public void SetFechaResultado(DateTime fechita) { FechaResultado = fechita; return; }
		public sCANTIDAD GetResultado() { return Resultado; }
		public void SetResultado(sCANTIDAD resultado) { Resultado = resultado; return; }
		public string GetObservacion() {  return Observacion; }
		public void SetObservacion(string observacion) { Observacion = observacion; return; }
		public EQUIPO GetEquipo() {  return Equipo; }
		public void SetEquipo(EQUIPO equipo) {  Equipo = equipo; return; }
		public TECNICA GetTecnico() { return Tecnica; }
		public void SetTecnica(TECNICA tecnica) { Tecnica = tecnica; return; }
        #endregion

        public RESULTADO() {

		}

		//Estos de acá son getters & setters?
		//public void CargarEquipo() { }
		//public void CargarTecnica() { }
	}
}