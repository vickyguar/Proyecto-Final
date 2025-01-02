using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    public class INVESTIGADOR {
        
        public uint id;
        public string Usuario; //:::
        public string Contrasena;   //::: Agregué estos dos acá para validar
        private string Nombre;
        private string Apellido;
        private string Email;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; return; }
        public string GetApellido() { return Apellido; }
        public void SetApellido(string apellido) { Apellido = apellido; return; }
        public string GetEmail() { return Email; }
        public void SetEmail(string email) { Email = email; return; }
        #endregion

        // Completar

        public INVESTIGADOR() {

        }
    }
}
