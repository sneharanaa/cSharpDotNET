using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuoptionMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderentry oentry = new orderentry();
            oentry.MdiParent = this;
            oentry.Show();
        }

        private void modifyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyorder morder = new modifyorder();
            morder.MdiParent = this;
            morder.Show();
        }

        private void last15daysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            last15days last15day = new last15days();
            last15day.MdiParent = this;
            last15day.Show();
        }

        private void highOrderValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            highordervalue value = new highordervalue();
            value.MdiParent = this;
            value.Show();
        }

        private void productOrder2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productorderdmore more = new productorderdmore();
            more.MdiParent = this;
            more.Show();
        }
    }
}
