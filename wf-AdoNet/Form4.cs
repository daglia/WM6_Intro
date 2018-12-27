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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(
            "Data Source = WISSEN\\MSSQL2017;" +
            "Initial Catalog = NorthwindSabah;" +
            "uid=alper; pwd=1234");

        private void Form4_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            cbCategories.Items.Clear();
            SqlCommand comm = new SqlCommand($"select CategoryName from Categories", conn);

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    cbCategories.Items.Add(dr[0].ToString());
                    i++;
                }
                dr.Close();
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

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            SqlCommand comm = new SqlCommand($"select ProductId, ProductName, UnitPrice, UnitsInStock, p.CategoryID, CategoryName " +
                $"from Products p inner join Categories c on p.CategoryID = c.CategoryID " +
                $"where CategoryName = @CategoryName", conn);

            comm.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = cbCategories.SelectedItem.ToString();

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvProducts.Items.Add(dr[0].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[1].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[2].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[3].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[4].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[5].ToString());
                    i++;
                }
                dr.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
