using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//TODO: qu� era T�cnica? el nombre de la profesional, no? vuela?

namespace BLL
{
	public class TECNICA {

		private uint id;
		private string Nombre;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; return; }
        #endregion

        public TECNICA() {

		}
	}
}