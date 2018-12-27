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

namespace wf_AdoNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(
            "Data Source = WISSEN\\MSSQL2017;" +
            "Initial Catalog = NorthwindSabah;" +
            "uid=sa; pwd=12345");

        private void btnGetAllCategories_Click(object sender, EventArgs e)
        {
            lvCategories.Items.Clear();
            SqlCommand comm = new SqlCommand($"select CategoryID, CategoryName, Description from Categories", conn);

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvCategories.Items.Add(dr[0].ToString());
                    lvCategories.Items[i].SubItems.Add(dr[1].ToString());
                    lvCategories.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
                }dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close(); // Her durumda bağlantı sonlandırılır.
            }
        }
    }
}
