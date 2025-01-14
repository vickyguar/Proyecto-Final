using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL
{
    namespace BLL_CLASS
    {
        public interface IMUESTRA<T>
        {
            T Buscar(uint id);
            List<T> BuscarTodos();
            List<T> BuscarTodos(uint id_raton);
            string[] DevolverDatos(uint id);
            int Borrar(uint id);
            int DeshacerBorrar(uint id);

        }
    }
}