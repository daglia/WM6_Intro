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
    public partial class Form1 : Form
    {
        // Bağlantı özellikleri tanımlaması
        SqlConnection conn = new SqlConnection(
            "Data Source = WISSEN\\MSSQL2017;" +
            "Initial Catalog = NorthwindSabah;" +
            "uid=sa; pwd=12345");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            // SQL'de çalışacak sorgu tanımlanır.

            //SqlCommand comm = new SqlCommand($"select CategoryName from Categories where CategoryID = {int.Parse(txtCategoryId.Text)}", conn);

            if (txtCategoryId.Text.Trim() != "")
            {
                SqlCommand comm = new SqlCommand($"select CategoryName from Categories where CategoryID = @Id", conn);

                comm.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtCategoryId.Text);

                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    txtCategoryName.Text = comm.ExecuteScalar().ToString();
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
}
