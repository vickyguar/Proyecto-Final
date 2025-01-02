using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	public class RAYOS : TRATAMIENTO {
		
		private float Dosis;

        #region GETTERS & SETTERS
		public float GetDosis() {  return Dosis; }
		public void SetDosis(float dosis) {  Dosis = dosis; return; }
        #endregion

        public RAYOS() {

		}
	}
}