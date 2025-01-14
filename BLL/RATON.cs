using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BLL
{
    namespace BLL_ENT
    {
        public class RATON_Ent
        {
            // Atributos pre-sacrificio
            public uint id { get; set; }
            public eGENERO Genero { get; set; }
            public DateTime FechaNacimiento { get; set; }
            private uint Jaula { get; set; }
            private string MarcaOreja { get; set; }
            private uint Control { get; set; }

            // foreign keys
            public uint idExperimento { get; set; }
            public uint idCepa { get; set; }
            public uint idGenotipo { get; set; }
            public List<uint> idTratamiento { get; set; }

            //public List<uint> id_Seguimiento { get; set; }  -> como seguimiento es muchos seguimientos a 1 raton el idRaton esta en seguimietno
            // public List<uint> id_Muestras { get; set; } -> como es muchas muestras de 1 raton el idRaton esta en muestra


            // Atributos post-sacrificio
            public DateTime FechaSacrificio { get; set; }
            private float PesoRatonSinTumor { get; set; }
            private string LinkFotoSacrificio { get; set; }


            //flags
            public uint Sacrificio { get; set; }
            // null hasta que Sacrificio cambie → para asegurar q carguen todo
            public bool Eliminado { get; set; }
            
        }
    }
    namespace BLL_CLASS
    {
        public class RATON_Class
        {
            #region CREATE
            public int Agregar(uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.Agregar(id_experimento, fecha_nacimiento, genero, control, id_cepa, id_genotipo, id_tratamiento);
                
                map = null;
                return resultado;
            }
            #endregion

            #region READ
            public BLL_ENT.RATON_Ent Buscar(uint id)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                BLL_ENT.RATON_Ent ent = map.Buscar(id);
                map = null;
                return ent;
            }
            public BLL_ENT.RATON_Ent Buscar(string marca_oreja)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                BLL_ENT.RATON_Ent ent = map.Buscar(marca_oreja);
                map = null;
                return ent;
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodos(uint id_experimento)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodos(id_experimento);
                map = null;
                return lista;
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxTratamiento(uint id_tratamiento)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxTratamiento(id_tratamiento);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxJaula(uint id_jaula)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxJaula(id_jaula);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxGenero(eGENERO genero)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxGenero(genero);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxPesoSinTumor(float peso_sin_tumor)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxPesoSinTumor(peso_sin_tumor);
                map = null;
                return lista;
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxFechaNacimiento(DateTime fecha_nacimiento)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxFechaNacimiento(fecha_nacimiento);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxFechaSacrificio(DateTime fecha_sacrificio)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxFechaSacrificio(fecha_sacrificio);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxControl(bool control)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxControl(control);
                map = null;
                return lista;
            }
            public List<BLL_ENT.RATON_Ent> BuscarTodosxCepa(uint id_cepa)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                List<BLL_ENT.RATON_Ent> lista = map.BuscarTodosxCepa(id_cepa);
                map = null;
                return lista;
            }
            #endregion

            #region  UPDATE
            public int Actualizar(uint id, uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.Actualizar(id, id_experimento, fecha_nacimiento, genero, control, id_cepa, id_genotipo, id_tratamiento);
                map = null;
                return resultado;
            }
            public int ActualizarOreja(uint id, uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento, uint jaula, string marca_oreja)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.ActualizarOreja(id, id_experimento, fecha_nacimiento, genero, control, id_cepa, id_genotipo, id_tratamiento, jaula, marca_oreja);
                map = null;
                return resultado;
            }

            public int Sacrificar(uint id, uint sacrificio, DateTime fecha_sacrificio, float peso_sin_tumor, string link_foto_sacrificio)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.Sacrificar(id, sacrificio, fecha_sacrificio, peso_sin_tumor, link_foto_sacrificio);
                map = null;
                return resultado;
            }
            #endregion

            #region DELETE
            public int Borrar(uint id)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.Borrar(id);
                map = null;
                return resultado;
            }
            public int DeshacerBorrar(uint id)
            {
                BLL_MAP.RATON_Map map = new BLL_MAP.RATON_Map();
                int resultado = map.DeshacerBorrar(id);
                map = null;
                return resultado;
            }

            #endregion

        }
    }
    namespace BLL_MAP
    {
        public class RATON_Map
        {
            #region CREATE
            public int Agregar(uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento)
            {
                DAL.sqlServer sqlServer = new DAL.sqlServer();
                SqlConnection Conn = new SqlConnection();
                Conn = sqlServer.AbrirConexion(Conn);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "RATON_Agregar";
                Cmd.CommandType = CommandType.StoredProcedure;
                //aca deberia de autosetearse el idRaton, Eliminado en false y la flag Sacrificar en false

                Cmd.Connection = Conn;

                Cmd.Parameters.Add("idExperimento", SqlDbType.Int);
                Cmd.Parameters["idExperimento"].Value = id_experimento;

                Cmd.Parameters.Add("FechaNacimiento", SqlDbType.DateTime);
                Cmd.Parameters["FechaNacimiento"].Value = fecha_nacimiento;

                Cmd.Parameters.Add("Genero", SqlDbType.Int);
                Cmd.Parameters["Genero"].Value = genero;

                Cmd.Parameters.Add("Control", SqlDbType.Int);
                Cmd.Parameters["Control"].Value = control;

                Cmd.Parameters.Add("idCepa", SqlDbType.Int);
                Cmd.Parameters["idCepa"].Value = id_cepa;

                Cmd.Parameters.Add("idGenotipo", SqlDbType.Int);
                Cmd.Parameters["idGenotipo"].Value = id_genotipo;

                Cmd.Parameters.Add("idTratamiento", SqlDbType.Int);
                Cmd.Parameters["idTratamiento"].Value = id_tratamiento;

                int resultado = sqlServer.EjecutarSQL_Int(Cmd);
                sqlServer.CerrarConexion(Conn);
                return resultado;
            }
            #endregion

            #region READ

            public BLL_ENT.RATON_Ent Buscar(uint id)
            {
                throw new NotImplementedException();
            }
            public BLL_ENT.RATON_Ent Buscar(string marca_oreja)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodos(uint id_experimento)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxControl(bool control)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxFechaNacimiento(object fecha_nacimiento)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxFechaSacrificio(DateTime fecha_sacrificio)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxGenero(eGENERO genero)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxJaula(uint id_jaula)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxPesoSinTumor(float peso_sin_tumor)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxTratamiento(uint id_tratamiento)
            {
                throw new NotImplementedException();
            }

            public List<BLL_ENT.RATON_Ent> BuscarTodosxCepa(uint id_cepa)
            {
                throw new NotImplementedException();
            }
            #endregion

            #region UPDATE

            public int ActualizarOreja(uint id, uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento, uint jaula, string marca_oreja)
            {
                throw new NotImplementedException();
            }
            public int Sacrificar(uint id, uint sacrificio, DateTime fecha_sacrificio, float peso_sin_tumor, string link_foto_sacrificio)
            {
                throw new NotImplementedException();
            }
            #endregion

           
            #region ELIMINAR
            public int Borrar(uint id)
            {
                throw new NotImplementedException();
            }

            public int DeshacerBorrar(uint id)
            {
                throw new NotImplementedException();
            }

            public int Actualizar(uint id, uint id_experimento, DateTime fecha_nacimiento, eGENERO genero, uint control, uint id_cepa, uint id_genotipo, uint id_tratamiento)
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
   
}
