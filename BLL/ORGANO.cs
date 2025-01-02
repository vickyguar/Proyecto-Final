using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	public class ORGANO : MUESTRA {

        public NOMBRE_ORGANO Organo;
        private float Peso;
        private uint Metastasis;
		private string Observacion;

        #region GETTERS & SETTERS
        public NOMBRE_ORGANO GetOrgano() {  return Organo; }
		public void SetOrgano(NOMBRE_ORGANO organo) { Organo = organo; return; }
		public float GetPeso() { return Peso; }
		public void SetPeso(float peso) {  Peso = peso; return; }
		public uint GetMetastasis() {  return Metastasis; }
		public void SetMetastasis(uint metastasis) { Metastasis = metastasis; return; }
		public string GetObservacion() { return  Observacion; }
		public void SetObservacion(string observacion) { Observacion = observacion; return; }
        #endregion

        public ORGANO() {

		}
	}
}