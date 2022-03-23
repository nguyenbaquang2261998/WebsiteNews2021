using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolCrawData
{
    public partial class Form1 : Form
    {
        SqlConnection SQLConnection = new SqlConnection(@"server=localhost;database=genz;user=root;password=;");
        public Form1()
        {
            InitializeComponent();
            GetDataBase();
        }
        public DataTable GetDataBase()
        {
            SQLConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM news";
            cmd.Connection = SQLConnection;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader myReader = cmd.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }
    }
}
