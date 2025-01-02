using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// TODO: resolver acá
/// Micela Cargada de PTX viene en [ ] fija de 4mg/ml & al animal se inyecta 10
/// mg/kg de PTX por un cálculo que hacen (esta concentracion es la de la inyeccion)

/// blanco = soluplus, +6ps
/// cargadas (droga) = soluplus+ -> HA, PTX

namespace BLL
{
    public class MICELA {

        private uint id;
        private string Nombre;
        private bool Blanco;
        private float ConcentracionDrogaxMicela; // TODO: Si es blanco, ¿ConcentracionDrogaxMicela = 0? De qué droga? Esto acá?

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; return; }
        public bool GetBlanco() { return Blanco; }
        public void SetBlanco(bool blanco) { Blanco = blanco; return; }
        public float GetConcentracionDrogaxMicela() { return ConcentracionDrogaxMicela; }
        public void SetConcentracionDrograxMicela(float concentracion) { ConcentracionDrogaxMicela = concentracion; return; }
        #endregion

        public MICELA() {

		}
	}
}