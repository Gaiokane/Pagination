using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pagination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DB db = new DB();

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM `info`";
            DataSet ds = db.GetDataSet(Query);
            //dataGridView1.DataSource = db.GetDataSet(Query).Tables[0];
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string Query = "select * from info where xxx = 'q'";
            label1.Text = db.GetRows(Query).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paginator1.NowPage = 666;
            //MessageBox.Show(paginator1.NowPage.ToString());
        }
    }
}
