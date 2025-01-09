using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BLL
{
	namespace BLL_Entidades
	{
		public class SEGUIMIENTO_Ent
        {
			public uint id { get; set; }
			public DateTime FechaSeguimiento { get; set; }
			public float PesoRaton { get; set; }
			public float TamanoRaton { get; set; }
			public float VolumenTumor { get; set; }

			//foreign keys
			public uint id_Raton { get; set; }
			public uint id_Experimento { get; set; }
		
			public bool Eliminado { get; set; }
		}
	}
	namespace BLL_Clases
	{
		public class SEGUIMIENTO_BLL
        {

			public int CalcularVolumen(float a, float b)
			{
				float volumenTumor;
				volumenTumor = (float)Math.PI * (float)Math.Pow(a + b, 2) / 12; //TODO: no era asi, pero me lo imaginé

				BLL_Map.SEGUIMIENTO_Map map = new BLL_Map.SEGUIMIENTO_Map();
				int resultado = map.SetVolumenTumor(volumenTumor);
				map = null;
				return resultado;
			}


		}
	}
	namespace BLL_Map
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