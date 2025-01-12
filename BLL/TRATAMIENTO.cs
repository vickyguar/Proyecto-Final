using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    namespace BLL_CLASS
    { 
        public interface ITRATAMIENTO<T>
        {
            T Buscar(uint id);
            List<T> BuscarTodos();
            List<T> BuscarTodos(uint id_experimento);
            string[] DevolverDatos(uint id);
            int BorrarUno(uint id);
            int DeshacerBorrarUno(uint id);
            
        }
    }

}
