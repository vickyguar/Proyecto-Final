using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//TODO: Resolver acá
// No tiene id porque lo hereda de tratamiento?
// unidad mg/kg en caso de MICELAS

namespace BLL
{
	public class INYECCION : TRATAMIENTO {

        private string Droga;
        private string CatalogNum;
        private float Dosis; // TODO: documentar qué es la dosis
        private string Vehiculo; //TODO: vuela?
        public MICELA Micela;
        private eADMINISTRACION Administracion;

        #region GETTERS & SETTERS
        public string GetDroga() {  return Droga; }
        public void SetDroga(string droga) {  Droga = droga; return; }
        public string GetCatalogNum() { return CatalogNum; }
        public void SetCatalogNum(string catalogNum) { CatalogNum = catalogNum; return; }
        public float GetDosis() { return Dosis; }
        public void SetDosis(float dosis) { Dosis = dosis; return; }
        public string GetVehiculo() {  return Vehiculo; }
        public void SetVehiculo(string vehiculo) { Vehiculo = vehiculo; return; }
        public MICELA GetMicela() { return Micela; }
        public void SetMicela(MICELA micela) { Micela = micela; return; }
        public eADMINISTRACION GetAdministracion() { return Administracion; }
        public void SetAdministracion(eADMINISTRACION administracion) { Administracion = administracion; return; }
        #endregion

        //public VEHICULO Vehiculo; 
        // public NOMBRE_DROGA NombreDroga;

        public INYECCION()
		{

		}

		//public void TratamientoxMicela(MICELA Micela = null) { }
	}
}