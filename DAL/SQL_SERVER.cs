using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class sqlServer
    {
        private SqlConnection Conn;
        public sqlServer()
        {
            this.Conn = new SqlConnection();
        }
        private string ArmarSqlConnection()
        {
            return "Data Source=DESKTOP-4B18TUO\\SQLEXPRESS;Initial Catalog=UCA;Integrated Security=True";
        }
        public SqlConnection AbrirConexion(SqlConnection Param_Conn)
        {
            if (Param_Conn != null)
            {
                this.Conn.ConnectionString = ArmarSqlConnection();
                try
                {
                    while (this.Conn.State == ConnectionState.Closed)
                    {
                        this.Conn.Open();
                    }
                }
                catch (Exception ex)
                {
                    ReportarErrores(ex.Message);
                }
            }
            else
            {
                this.Conn = Param_Conn;
            }
            return this.Conn;
        }
        public void CerrarConexion(SqlConnection Param_Conn)
        {
            if (this.Conn != null)
            {
                Param_Conn.Close();
            }
        }
        public DataTable EjecutarSQL_DT(SqlCommand Param_Cmd)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Param_Cmd;
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ReportarErrores(ex.Message);
            }
            return ds.Tables[0]; // TODO por que en cero?

        }
        public int EjecutarSQL_Int(SqlCommand Param_Cmd)
        {
            int devolucion = 1;
            try
            {
                Param_Cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                devolucion = -1;
                //throw new Exception("Error en DAL, método EjectuarSQL_Int");
            }
            return devolucion;
        }
        private void ReportarErrores(string detalle_error)
        {
            StreamWriter archivo = new StreamWriter("bitacora.txt", true);
            archivo.WriteLine(DateTime.Now.ToString() + ";" + detalle_error);
            archivo.Close();
        }
    }
}
