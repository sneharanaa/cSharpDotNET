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

namespace menuoptionMDI
{
    public partial class orderentry: Form
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=sqldb;Integrated Security=True";
        public orderentry()
        {
            InitializeComponent();
            loadcustomer();
            loadproduct();
        }

        public void loadcustomer()
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = "select cid , name from customer";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbcustomer.DataSource = dt;
            cmbcustomer.DisplayMember = "name";
            cmbcustomer.ValueMember = "cid";
        }

        public void loadproduct()
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = "select * from product";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbproduct.DataSource = dt;
            cmbproduct.DisplayMember = "pname";
            cmbproduct.ValueMember = "pid";
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbproduct.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cmbproduct.SelectedItem;
                txtunit.Text = row["unit"].ToString();
                txtprice.Text = row["price"].ToString();
            }
        }

        private void orderentry_Load(object sender, EventArgs e)
        {
            
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "" && txtprice.Text != "")
            {
                decimal total = Convert.ToUInt32(txtqty.Text) * Convert.ToDecimal(txtprice.Text);
                txttot.Text = total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            string qry = "insert into orders(cid , pid , qty , totamt) values(@cid , @pid , @qty , @totamt)";
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@cid", cmbcustomer.SelectedValue);
            cmd.Parameters.AddWithValue("@pid", cmbproduct.SelectedValue);
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtqty.Text));
            cmd.Parameters.AddWithValue("@totamt", Convert.ToDecimal(txttot.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order Inserted Successfully");
        }
    }
}
