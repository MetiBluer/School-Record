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
    public partial class Form3 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Documents\\schoolSupplies.accdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            display_records();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO teacher(fullname,email,sex) VALUES('" + txtFname.Text + "','" + txtEmail.Text + "','"+txtSex.Text+"')";
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
            cmd.CommandText = "UPDATE teacher SET fullname = '" + txtFname.Text + "' , email ='" + txtEmail.Text + "', sex = '"+txtSex.Text+"' WHERE fullname = '" + txtFname.Text + "'";
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
            cmd.CommandText = "DELETE * FROM teacher WHERE fullname = '" + txtFname.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted");
            display_records();
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM teacher WHERE fullname LIKE '" + txtSearch.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecords.DataSource = dt;
            clear();
        }
        void display_records()
        {
            string query = "SELECT * FROM teacher order by idnumber asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecords.DataSource = dt;

        }
        void clear()
        {
            txtFname.Text = "";
            txtEmail.Text = "";
            txtSex.Text = "";
            txtSearch.Text = "";
        }
    }
}
