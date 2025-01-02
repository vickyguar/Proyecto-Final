using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class EXPERIMENTO {
        private uint id;
        private eESTADO Estado;
        private DateTime FechaInicio;
        private DateTime FechaFin;
        private string Titulo;

        private List<INOCULACION> Inoculaciones;
        private List<TRATAMIENTO> Tratamientos;

        #region FUNCIONES p LISTAS
        public void Agg(INOCULACION inoc) {
            Inoculaciones.Add(inoc);
        }

        public void Agg(TRATAMIENTO trat) {
            Tratamientos.Add(trat);
        }

        // TODO: Quitar de tablas
        public void QuitarInoculacion() {

        }

        public void QuitarTratamiento() {

        }

        public INOCULACION BuscarInoculacion(uint idInoculacion) {
            INOCULACION MiInoc = new INOCULACION();
            MiInoc = Inoculaciones.Find(x => x.GetId() == idInoculacion);
            return MiInoc;
        }

        public List<INOCULACION> BuscarInoculacion() {
            return Inoculaciones;
        }

        public TRATAMIENTO BuscarTratamiento(uint idTratamiento) {
            TRATAMIENTO MiTrat = new TRATAMIENTO();
            MiTrat = Tratamientos.Find(x => x.GetId() == idTratamiento);
            return MiTrat;
        }

        public List<TRATAMIENTO> BuscararTratamiento() {
            return Tratamientos;
        }
        #endregion

        #region GETTERS & SETTERS
        public uint GetId() { return id; }
        public void SetId(uint _id) { id = _id; return; }
        public string GetTitulo() { return Titulo; }
        public void SetTitulo(string titulo) { Titulo = titulo; return; }
        public DateTime GetIdFechaInicio() { return FechaInicio; }
        public void SetFechaInicio(DateTime fechita) { FechaInicio = fechita; return; }
        public DateTime GetFechaFin() { return FechaFin; }
        public void SetFechaFin(DateTime fechita) { FechaFin = fechita; return; }
        public eESTADO GetEstadoExperimento() { return Estado; }
        public void SetEstadoExperimento(eESTADO estado) { Estado = estado; return; }
        #endregion

        public EXPERIMENTO() {
            Inoculaciones = new List<INOCULACION>();
            Tratamientos = new List<TRATAMIENTO>();
        }
    }
}
