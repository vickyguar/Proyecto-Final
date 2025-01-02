using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL {
    public class CEPA {

        private uint id;
        private string Nombre;

        #region GETTERS & SETTERS
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; return; }
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        #endregion

        public CEPA() {

        }
    }
}