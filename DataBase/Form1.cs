using DataBase.nricontactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        nricontactClass c = new nricontactClass();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtContactID.Text);
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtContactNumber.Text;
            c.Address = txtAddress.Text;
            c.Gender = comGender.Text;

            bool success = c.Insert(c);
            if(success==true)
            {
                MessageBox.Show("New Contact successfully Inserted");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add New Contact.Try Again");
            }
            DataTable dt = c.Select();
            dgContactList.DataSource = dt;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgContactList.DataSource = dt;

        }
        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            comGender.Text = "";
            txtContactID.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtContactID.Text);
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtContactNumber.Text;
            c.Address = txtAddress.Text;
            c.Gender = comGender.Text;
            bool success = c.Update(c);
            if(success ==true)
            {
                MessageBox.Show("Contact has been successfully Updated.");
                DataTable dt = c.Select();
                dgContactList.DataSource = dt;
                clear();


            }
            else
            {
                MessageBox.Show("Failed to Update contact.Try Again. ");

            }
        }

        private void dgContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtContactID.Text = dgContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactNumber.Text = dgContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comGender.Text = dgContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(txtContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact successfully Deleted.");
                DataTable dt = c.Select();
                dgContactList.DataSource = dt;
                clear();


            }
            else
            {
                MessageBox.Show("Failed to Delete Contact.Try Again. ");
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString; 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM tbl_contact WHERE FirstName LIKE '%" + keyword +"%' OR LastName LIKE '%"+keyword +"%'OR Address LIKE '%"+keyword +"%'OR ContactNo LIKE '%"+keyword +"%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgContactList.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
