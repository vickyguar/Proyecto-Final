using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class RATON {
        
        // Atributos pre-sacrificio
        private uint id;
        private eGENERO Genero;
        public CEPA CEPA;
        public GENOTIPO Genotipo;
        private DateTime FechaNacimiento;
        private uint Jaula;
        private string MarcaOreja;
        private bool Control; // No podría ser calculable? "Si tratamiento es null → es control"

        // Atributos post-sacrificio // TODO: null hasta que Sacrificar → habría que tener flag?
        private DateTime FechaSacrificio;
        private float PesoRatonSinTumor;
        private string LinkFotoSacrificio;
		
		public List<SEGUIMIENTO> Seguimientos;
		public List<MUESTRA> Muestras;

        #region FUNCIONES p LISTAS
        public void Agg(SEGUIMIENTO seg) {
            Seguimientos.Add(seg);
            return;
        }

        public void Agg(MUESTRA muestra) {
            Muestras.Add(muestra);
            return;
        }

        // TODO: Quitar de tablas

        public List<SEGUIMIENTO> BuscarSeguimiento() {
            return Seguimientos;
        }

        public SEGUIMIENTO BuscarSeguimiento(uint idSeg) {
            SEGUIMIENTO MiSeguimiento = new SEGUIMIENTO();
            MiSeguimiento = Seguimientos.Find(x => x.GetId() == idSeg);
            return MiSeguimiento;
        }

        public List<MUESTRA> BuscarMuestra() {
            return Muestras;
        }

        public MUESTRA BuscarMuestra(uint idSeg) {
            MUESTRA MiMuestra = new MUESTRA();
            MiMuestra = Muestras.Find(x => x.GetId() == idSeg);
            return MiMuestra;
        }
        #endregion

        #region GETTERS & SETTERS
        public uint GetId() {  return id; }
        public void SetId(uint _id) {  id = _id; return; }
        public eGENERO GetGENERO() { return Genero; }
        public void SetGenero(eGENERO genero) {  Genero = genero; return; }
        public CEPA GetCepa() { return CEPA; }
        public void SetCepa(CEPA cepa) { CEPA = cepa; return; }
        public GENOTIPO GetGenotipo() { return Genotipo; }
        public void SetGenotipo(GENOTIPO genotipo) { Genotipo = genotipo; return; }
        public DateTime GetFechaNacimiento() { return FechaNacimiento; }
        public void SetFechaNacimiento(DateTime fechita) { FechaNacimiento = fechita; return; }
        public string GetMarcaOreja() { return MarcaOreja; }
        public void SetMarcaOreja(string marcaOreja) {MarcaOreja = marcaOreja; return; }
        public bool GetControl() {  return Control; }
        public void SetControl(bool control) { Control = control; return; }
        public DateTime GetFechaSacrificio() {  return FechaSacrificio; }
        public void SetFechaSacrificio(DateTime fechita) { FechaSacrificio = fechita; return; }
        public float GetPesoRatonSinTumor() { return PesoRatonSinTumor; }
        public void SetPesoRatonSinTumor(float pesoRatonSinTumor) { PesoRatonSinTumor = pesoRatonSinTumor; return; }
        public string GetLinkFotoSacrificio() { return LinkFotoSacrificio; }
        public void SetLinkFotoSacrificio(string link) { LinkFotoSacrificio = link; return; }
        #endregion

        public RATON() {
            Seguimientos = new List<SEGUIMIENTO>();
            Muestras = new List<MUESTRA>();
        }
	}
}
