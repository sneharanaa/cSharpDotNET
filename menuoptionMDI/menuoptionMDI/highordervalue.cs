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
    public partial class highordervalue : Form
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=sqldb;Integrated Security=True";

        public highordervalue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = "select distinct c.name , c.city , o.totamt from orders o inner join customer c on o.cid = c.cid where o.totamt > @totamt order by o.totamt desc";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            da.SelectCommand.Parameters.AddWithValue("@totamt", 2000);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
