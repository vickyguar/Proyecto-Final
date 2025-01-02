using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// TODO: resolver acá

namespace BLL
{
	public class MUESTRA {

        private uint id;
        private DateTime FechaMuestra;
		private int NumHistopato;
		private int TipoMuestra; // Heces, sangre
		public RESULTADO Resultado;

        #region GETTERS & SETTERS
        public uint GetId() {  return id; }
		public void SetId(uint _id) { id = _id; return; }
		public DateTime GetFechaMuestra() { return FechaMuestra; }
		public void SetFechaMuestra(DateTime fechita) { FechaMuestra = fechita; return; }
		public int GetNumHistopato() {  return NumHistopato; }
		public void SetNumHistopato(int num) {  NumHistopato = num; return; }
		public int GetTipoMuestra() { return TipoMuestra; }
		public void SetTipoMuestra(int tipo) { TipoMuestra = tipo; return; }
		public RESULTADO GetResultado() { return Resultado; }
		public void SetResultado(RESULTADO resultaddo) {  Resultado = resultaddo; return; }
        #endregion

        public MUESTRA() {

		}

		//public void CargarResultado() { }
	}
}