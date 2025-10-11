using System;
using System.Data;
using System.Windows.Forms;
using Group5HotelsProject.Properties;
using Microsoft.Data.SqlClient;

namespace Group5HotelsProject.Data
{
    public class DB
    {
        #region Attributes
        protected SqlConnection cnMain;
        protected SqlDataAdapter? daMain;
        protected DataSet dsMain;
        #endregion

        #region Enumerations
        public enum DBOperation
        {
            Add,
            Edit,
            Delete
        }
        #endregion

        #region Constructors
        public DB()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\timsa\\source\\repos\\keenanpretorius\\Group5HotelsProject\\Group5HotelsProject\\Data\\PKH Database.mdf\";Integrated Security=True";
            cnMain = new SqlConnection(connectionString);
            dsMain = new DataSet();
        }
        #endregion

        #region Protected Methods
        protected void FillDataSet(string sql, string tableName)
        {
            try
            {
                daMain = new SqlDataAdapter(sql, cnMain);
                daMain.Fill(dsMain, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filling dataset for table '{tableName}': {ex.Message}");
            }
        }

        protected bool UpdateDataSource(string sql, string tableName)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(daMain);
                daMain.Update(dsMain, tableName);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region Public Methods
        public DataSet GetDataSet() => dsMain;
        #endregion
    }
}
