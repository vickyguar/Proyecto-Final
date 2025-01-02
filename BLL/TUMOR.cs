using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	public class TUMOR : MUESTRA {

		private uint NumVasos;
		private float PesoTumor;

        #region GETTERS & SETTERS
        public uint GetNumVasos() {  return NumVasos; }
		public void SetNumVasos(uint numVasos) { NumVasos = numVasos; return; }
		public float GetPesoTumor() {  return PesoTumor; }
		public void SetPesoTumor(float pesoTumor) { PesoTumor = pesoTumor; return; }
        #endregion

        public TUMOR() {

		}
	}
}