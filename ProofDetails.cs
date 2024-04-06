using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRIcontact
{
    public partial class ProofDetails : Form
    {
        public ProofDetails()
        {
            InitializeComponent();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new NRIcontactLoginForm().Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new NRIcontact().Show();
            this.Hide();
        }

        private void ProofDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nRIcontactDataSet2.tbl_picture' table. You can move, or remove it, as needed.
            this.tbl_pictureTableAdapter.Fill(this.nRIcontactDataSet2.tbl_picture);

            LoadData();
        }

        public void Insert(String PassportId,String AadharNumber,String FileName,byte[] Image)
        {
            using(SqlConnection cn=new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-JNRPSK4;Initial Catalog=NRIcontact;Integrated Security=True;"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using(SqlCommand cmd=new SqlCommand("insert into tbl_picture(PassportID,AadharNumber,FileName,Image) values(@PassportID,@AadharNumber,@FileName,@Image)",cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PassportID", txtboxPassportID.Text);
                    cmd.Parameters.AddWithValue("@AadharNumber", txtboxAadharNumber.Text);
                    cmd.Parameters.AddWithValue("@FileName", txtboxFileName.Text);
                    cmd.Parameters.AddWithValue("@Image", Image);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void LoadData()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-JNRPSK4;Initial Catalog=NRIcontact;Integrated Security=True;"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (DataTable dt = new DataTable("tbl_picture"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select *from tbl_picture", cn);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }

            }

        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms=new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog() { Filter="Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg",Multiselect=false})
            {
                pictureBox.Image = Image.FromFile(ofd.FileName);
                txtboxFileName.Text = ofd.FileName;
                Insert(txtboxPassportID.Text,txtboxAadharNumber.Text,txtboxFileName.Text, ConvertImageToBytes(pictureBox.Image));
                LoadData();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox.Image = ConvertByteArrayToImage((byte[])row["Image"]);
            }
        }
    }
}
