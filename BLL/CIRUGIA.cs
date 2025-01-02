using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// TODO: Clase CIRUGÍA no lleva id por heredarlo?

namespace BLL {
	public class CIRUGIA : TRATAMIENTO {

		private DateTime FechaCirugia;
		private float PorcentajeExtirpado;

        #region GETTERS & SETTERS
        public DateTime GetFechaCirugia() { return FechaCirugia; }
		public void SetFechaCirugia(DateTime fechita) { FechaCirugia = fechita; return; }
		public float GetPorcentajeExtirpado() { return PorcentajeExtirpado; }
		public void SetPorcentajeExtirpado(float porcentaje) { PorcentajeExtirpado= porcentaje; return; }
        #endregion

        public CIRUGIA() {

		}
	}
}