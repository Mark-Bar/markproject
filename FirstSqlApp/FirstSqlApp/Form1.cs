using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace FirstSqlApp
{
    public partial class Form1 : Form
    {
        string sqlConnection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadJobTitles();
        }

        private void LoadJobTitles()
        {
            string commandText = "select top 10 * from [dbo].[JobTitle] order by Id desc";

            using (var con = new SqlConnection(sqlConnection))
            {
                using (var command = new SqlCommand(commandText, con))
                {
                    con.Open();

                    DataTable jobTitles = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(jobTitles);

                    dgvJobTitles.DataSource = jobTitles;
                    con.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string jobTitle = txtJobTitle.Text;

            if (!String.IsNullOrEmpty(jobTitle))
            {
                string commandText = "insert into [dbo].[JobTitle](JobTitle) values(@jobTitle)";

                using (var con = new SqlConnection(sqlConnection))
                {
                    using (var command = new SqlCommand(commandText, con))
                    {
                        con.Open();

                        command.Parameters.AddWithValue("jobTitle", jobTitle);
                        command.ExecuteNonQuery();

                        LoadJobTitles();

                        con.Close();
                    }
                }
            }
        }
    }
}
