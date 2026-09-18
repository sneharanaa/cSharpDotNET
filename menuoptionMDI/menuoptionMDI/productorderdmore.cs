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
    public partial class productorderdmore: Form
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=sqldb;Integrated Security=True";

        public productorderdmore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = "select p.pname , count(*) as ordercount from orders o inner join product p on o.pid = p.pid group by p.pname having count(*) >= 2";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
            }
            dataGridView1.DataSource = dt;
        }
    }
}
