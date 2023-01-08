using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace DAL
{
    public class sqlServer
    {
        
        private SqlTransaction _transaction;
        private SqlCommand _command;
        public SqlConnection cnn;
        public sqlServer()
        {
            this.cnn = new SqlConnection();
        }

        private string makeSqlconnection()
        {
            return "Data Source=DESKTOP-R766G9B\\SQLEXPRESS;Initial Catalog=SalimJuanTPfinal;Integrated Security=True";
        }

        public SqlConnection openConnection()
        {
            this.cnn.ConnectionString = makeSqlconnection();
            try
            {
                while (this.cnn.State == ConnectionState.Closed)
                {
                    this.cnn.Open();
                }
            }
            catch (Exception ex)
            {
                
                
            }
            return this.cnn;
        }

        public void closeConnection(SqlConnection param_cnn)
        {
            if (this.cnn is null)
            {
                param_cnn.Close();
            }
        }

        public bool Write (string query, Hashtable hdatos)
        {
            openConnection();
            try
            {
                _transaction = cnn.BeginTransaction();
                _command = new SqlCommand(query, cnn, _transaction);
                _command.CommandType = CommandType.StoredProcedure;

                if (hdatos != null)
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        _command.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }
                int rta = _command.ExecuteNonQuery();
                _transaction.Commit();
                return true;    

            }
            catch (SqlException ex)
            {
                _transaction.Rollback();
               
                return false;   
            }
            finally
            {
                closeConnection(cnn);
            }
        }

        public DataTable Read (string query, Hashtable hdatos)
        {
            openConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            _command = new SqlCommand(query, cnn);
            _command.CommandType = CommandType.StoredProcedure;
            try
            {
                adapter = new SqlDataAdapter(_command);
                if ((hdatos != null))
                {
                    foreach(string dato in hdatos.Keys)
                    {
                        _command.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
                //capturar errores
            }
            catch (Exception ex)
            {
                //capturar errores
                throw ex;
            }
            adapter.Fill(dt);
            closeConnection(cnn);
            return dt;  

            
        }

    }
}
