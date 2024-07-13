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
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Documents\\schoolSupplies.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            display_records();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO subject(description,units) VALUES('"+txtDesc.Text+"','"+txtUnits.Text+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Added");
            display_records();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE subject SET description = '"+txtDesc.Text+"' , units ='"+txtUnits.Text+"' WHERE description = '"+txtDesc.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated");
            display_records();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM subject WHERE description = '"+txtDesc.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted");
            display_records();
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM subject WHERE description LIKE '" + txtSearch.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecords.DataSource = dt;
            clear();

        }
        void display_records()
        {
            string query = "SELECT * FROM subject order by code asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecords.DataSource = dt;
        }
        void clear()
        {
            txtDesc.Text = "";
            txtUnits.Text = "";
            txtSearch.Text = "";
        }
    }
}
