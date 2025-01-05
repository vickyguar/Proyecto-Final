using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    namespace BLL_Clases
    { 
        public interface TRATAMIENTO_BLL<T>
        {
            int AgregarUno(int id, sCANTIDAD tratamiento, string observacion, uint id_experimento);
            int BuscarUno();
            List<T> BuscarTodos();
            List<T> BuscarTodos(uint id_proyecto);

            string[] DevolverDatos(int id);
            int ModificarUno(string observacion, sCANTIDAD tratamiento);
            int BorrarUno(int id);
            int DeshacerBorrarUno(int id);
            
        }
    }

}
