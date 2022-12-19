using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FooDrinK
{
    class DataManage
    {
        protected SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source=.\\SQLEXPRESS;database=FooDrinK;integrated security=True";
            return Con;
        }
        
        public DataSet getData(string query)
        {
            DataSet DS = new DataSet();
            try
            {
                SqlConnection Con = getConnection();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = query;
                SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                DA.Fill(DS);
                return DS;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DS;
            }
        }

        public void setData(string query)
        {
            try
            {
                SqlConnection Con = getConnection();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Con.Open();
                Cmd.CommandText = query;
                Cmd.ExecuteNonQuery();
                Con.Close();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
