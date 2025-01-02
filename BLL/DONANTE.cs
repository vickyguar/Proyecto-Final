using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL {
	public class DONANTE {
        private uint id;
        public CEPA Cepa;
        private eGENERO Genero;
        private uint Edad;

        #region GETTERS & SETTERS
        public uint GetId() {  return id; }
        public void SetId(uint _id) {  id = _id; return; }
        public CEPA GetCepa() { return Cepa; }
        public void SetCepa(CEPA cepa) {  Cepa = cepa; return; }
        public eGENERO GetGenero() { return Genero; }
        public void SetGenero(eGENERO genero) { Genero = genero; return; }
        public uint GetEdad() { return Edad; }
        public void SetEdad(uint edad) {  Edad = edad; return; }
        #endregion

        public DONANTE() {

		}
	}
}