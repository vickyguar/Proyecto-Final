///////////////////////////////////////////////////////////
//  NOMBRE_ORGANO.cs
//  Implementation of the Class NOMBRE_ORGANO
//  Generated by Enterprise Architect
//  Created on:      23-sep.-2024 22:29:04
//  Original author: vguar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
    public class NOMBRE_ORGANO {

        private uint id;
        private string Nombre;

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; return; }
        #endregion

        public NOMBRE_ORGANO() {

        }
    }
}