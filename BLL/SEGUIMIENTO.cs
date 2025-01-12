using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	namespace BLL_ENT
	{
		public class SEGUIMIENTO_Ent
        {
			public uint id { get; set; }
			public DateTime FechaSeguimiento { get; set; }
			public float PesoRaton { get; set; }
			public float TamanoRaton { get; set; }
			public float VolumenTumor { get; set; }

			//foreign keys
			public uint idRaton { get; set; }
			public uint idExperimento { get; set; }
		
			public bool Eliminado { get; set; }
		}
	}
	namespace BLL_CLASS
	{
		public class SEGUIMIENTO_Class
        {

			public int CalcularVolumen(float a, float b)
			{
				float volumenTumor;
				volumenTumor = (float)Math.PI * (float)Math.Pow(a + b, 2) / 12; //TODO: no era asi, pero me lo imaginé

				BLL_MAP.SEGUIMIENTO_Map map = new BLL_MAP.SEGUIMIENTO_Map();
				int resultado = map.SetVolumenTumor(volumenTumor);
				map = null;
				return resultado;
			}


		}
	}
	namespace BLL_MAP
	{
		public class SEGUIMIENTO_Map
        {
			public int SetVolumenTumor(float volumen_tumor)
            {
				return 1;
            }
        }
	}
}