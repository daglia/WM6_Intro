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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(
            "Data Source = WISSEN\\MSSQL2017;" +
            "Initial Catalog = NorthwindSabah;" +
            "uid=alper; pwd=1234");

        private void Form3_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void GetAllCategories()
        {
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
            lvCategories.Items.Clear();
            if (txtCategoryName.Text.Trim() != "")
            {
                SqlCommand comm = new SqlCommand($"insert into Categories (CategoryName,Description)" +
                "values(@CategoryName, @Description)", conn);

                comm.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = txtCategoryName.Text;
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtDescription.Text;

                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Category eklendi.", "Kayıt tamamlandı.");
                        GetAllCategories();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi!", "Dikkat! Hata ile karşılaşıldı!");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Category Name girmelisiniz!","Dikkat! Eksik Bilgi!");
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
