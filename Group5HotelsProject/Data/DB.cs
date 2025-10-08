using System;
using System.Data;
using System.Windows.Forms;
using Group5HotelsProject.Properties;
using Microsoft.Data.SqlClient;



namespace Group5HotelsProject.Data
{
    public class DB
    {
        protected SqlConnection cnMain;
        protected SqlDataAdapter ? daMain;
        protected DataSet dsMain;


        public DB()
        {
            string connectionString = Settings.Default.ConnectionString;
            cnMain = new SqlConnection(connectionString);
            dsMain = new DataSet();
        }

        protected void FillDataSet(string sql, string tableName)
        {
            daMain = new SqlDataAdapter(sql, cnMain);
            daMain.Fill(dsMain, tableName);
        }
        public bool UpdateSource(string tableName)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(daMain);
            try
            {
                daMain?.Update(dsMain, tableName);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
                return false;
            }
        }
        public DataSet GetDataSet() => dsMain;
    }
}
