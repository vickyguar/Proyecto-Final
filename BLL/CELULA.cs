using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace BLL {
    namespace BLL_CLASS
    {
        public class CELULA_CLASS : INOCULACION
        {
            // CREATE
            public int Agregar(uint CantidadCelulas, uint LineaCelular)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                int resultado = map.Agregar(CantidadCelulas, LineaCelular);
                map = null;
                return resultado;
            }
            
            // READ
            public BLL_ENT.CELULA_ENT BuscarUno(uint id)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                BLL_ENT.CELULA_ENT ent = map.BuscarUno(id);
                map = null;
                return ent;
            }

            public BLL_ENT.CELULA_ENT BuscarUno(string LineaCelular)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                BLL_ENT.CELULA_ENT ent = map.BuscarUno(LineaCelular);
                map = null;
                return ent;
            }

            // UPDATE
            public int Actualizar(uint id, uint CantidadCelulas, uint LineaCelular)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                int resultado = map.Actualizar(id, CantidadCelulas, LineaCelular);
                map = null;
                return resultado;
            }

            // DELETE
            public int Eliminar(uint id, uint deleted)
            {
                BLL_MAP.CELULA_MAP map = new BLL_MAP.CELULA_MAP();
                int resultado = map.Eliminar(id, deleted);
                map = null;
                return resultado;
            }


        }
    }

    namespace BLL_ENT
    {
        public class CELULA_ENT
        {
            public uint id { get; set; }
            public uint CantidadCelulas { get; set; }
            //TODO: para mi se fue ayer (?)
            public uint LineaCelular { get; set; }
            public uint deleted { get; set; }
        }
    }

    namespace BLL_MAP
    {
        class CELULA_MAP
        {

        }
    }
}