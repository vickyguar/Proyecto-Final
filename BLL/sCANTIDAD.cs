using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace BLL
{
	public struct sCANTIDAD {

		public float Magnitud;
		public string Unidad;
	}
	/* sCANTIDAD se utiliza en los diversos tratamientos
	 * RAYOS -> dosis total, velocidad de entrega, energia de RX
	 * CIRUGIA -> % extirpado
	 * INYECCION -> dosis total en mg/kg
	 * MICELA -> concentracion de droga x micela
	*/

	//TODO: VER SI HACEMOS ENUM PARA UNIDAD
	//TODO: DEFINIR EL TO STRING PARA SCANTIDAD
}