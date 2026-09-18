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
    public partial class modifyorder : Form
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=sqldb;Integrated Security=True";
        private decimal productprice = 0;
        private int selectoid = 0;
        public modifyorder()
        {
            InitializeComponent();
            loadcustomer();
        }

        public void loadcustomer()
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = "select cid , name from customer";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "cid";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int)
            {
                SqlConnection con = new SqlConnection(constr);

                string qry = @"select o.oid, p.pname, o.qty, o.totamt, p.price
                       from orders o
                       inner join product p on o.pid = p.pid
                       where o.cid = @cid";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.SelectCommand.Parameters.AddWithValue("@cid", comboBox1.SelectedValue);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (dataGridView1.Columns.Contains("price"))
            {
                dataGridView1.Columns["price"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectoid = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["oid"].Value
                );

                txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString();
                txttot.Text = dataGridView1.Rows[e.RowIndex].Cells["totamt"].Value.ToString();

                productprice = Convert.ToDecimal(
                    dataGridView1.Rows[e.RowIndex].Cells["price"].Value
                );
            }
        }

        private void txttot_TextChanged(object sender, EventArgs e)
        {
            //txttot.Text = (Convert.ToInt32(txtqty.Text) * productprice).ToString();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "")
            {
                int qty = Convert.ToInt32(txtqty.Text);
                txttot.Text = (qty * productprice).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            string qry = @"update orders 
                   set qty = @qty , totamt = @totamt 
                   where oid = @oid";

            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtqty.Text));
            cmd.Parameters.AddWithValue("@totamt", Convert.ToDecimal(txttot.Text));
            cmd.Parameters.AddWithValue("@oid", selectoid);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated");
        }
    }
}
