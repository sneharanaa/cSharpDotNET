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
    public partial class last15days: Form
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=sqldb;Integrated Security=True";
        public last15days()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string qry = @"select p.pname, o.odt, o.qty, o.totamt from orders o inner join product p on o.pid = p.pid where o.odt >= DATEADD(day ,-15 , GETDATE()) order by o.odt desc";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
