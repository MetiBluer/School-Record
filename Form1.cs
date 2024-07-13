using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Exam_project
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Documents\\schoolSupplies.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOption.Items.Add("subject");
            cbOption.Items.Add("teacher");
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOption.SelectedIndex == 0)
            {
                string query = "SELECT * FROM subject order by code asc";
                OleDbCommand cmd = new OleDbCommand(query,conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
                lblIns.Text = "Insert Description";
                txtSearch.Text = "";
            }
            if(cbOption.SelectedIndex == 1)
            {
                string query = "SELECT * FROM teacher order by idnumber asc";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
                lblIns.Text = "Insert FullName ";
                txtSearch.Text = "";
            }
         
        }

        private void btnSubj_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            Form3 frm3= new Form3();
            frm3.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cbOption.SelectedIndex == 0)
            {
                string query = "SELECT * FROM subject WHERE description LIKE '"+txtSearch.Text+"' ";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
            }
            if(cbOption.SelectedIndex == 1)
            {
                string query = "SELECT * FROM teacher WHERE fullname LIKE '" + txtSearch.Text + "' ";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
            }
        }
    }
}
