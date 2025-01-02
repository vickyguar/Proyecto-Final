using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	public class SEGUIMIENTO {

        private uint id;
        private DateTime FechaSeguimiento;
		private float PesoRaton;
		private float TamanoRaton;
		private float VolumenTumor;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
		public void SetId(uint _id) { id = _id; return; }
		public DateTime GetFechaSeguimiento() {  return FechaSeguimiento; }
		public void SetFechaSeguimiento(DateTime fechita) { FechaSeguimiento = fechita; return; }
		public float GetPesoRaton() {  return PesoRaton; }
		public void SetPesoRaton(float pesoRaton) {PesoRaton = pesoRaton; return; }
		public float GetTamanoRaton() { return TamanoRaton; }
		public void SetTamanoRaton(float tamanoRaton) {TamanoRaton = tamanoRaton; return; }
		public float GetVolumenTumor() {  return VolumenTumor; }
		public void SetVolumenTumor(float volumenTumor) { VolumenTumor = volumenTumor; return; }
        #endregion

        public SEGUIMIENTO() {

		}

		//TODO: ahre esta funcion
		public void CalcularVolumen(float a, float b) {
			float volumenTumor;
			volumenTumor = (float)Math.PI * (float)Math.Pow(a + b, 2) / 12; //TODO: no era asi, pero me lo imaginé
			SetVolumenTumor(volumenTumor);
		}
	}
}