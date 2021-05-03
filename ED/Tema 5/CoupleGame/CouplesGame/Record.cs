using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CouplesGame
{
    public partial class Record : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Records.mdf;Integrated Security = True";
        public Record()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT TOP 5 * FROM [dbo].[Table] ORDER BY Tiempo asc", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                record4.DataSource = dtbl;
               
               
                sqlDa = new SqlDataAdapter("SELECT TOP 5 * FROM [dbo].[6x6] ORDER BY Tiempo asc", sqlCon);
                dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                record6.DataSource = dtbl;

            }
        }

        private void record4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            menu ventanaMenu = new menu();
            this.Close();
            ventanaMenu.Show();
        }
    }
}
