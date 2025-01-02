using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class PAPER {
        private uint id;
        private string Titulo;
        private string Link;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetTitulo() { return Titulo; }
        public void SetTitulo(string titulo) { Link = titulo; return; }
        public string GetLink() { return Link; }
        public void SetLink(string link) { Link = link; return; }
        #endregion

        public PAPER() { 

        }
    }
}
