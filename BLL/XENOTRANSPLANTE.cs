using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Policy;

namespace BLL
{
	public class XENOTRANSPLANTE : INOCULACION {

		public DONANTE Donante;

        #region GETTERS & SETTERS
        public DONANTE GetDonante() {  return Donante; }
		public void SetDonante(DONANTE donante) { Donante = donante; return; }
        #endregion

        public XENOTRANSPLANTE() {

		}
		// public void CargarDonantes(uint Cantidad) { }
	}
}