using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Digital_Shelf
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String bname=txtBookName.Text;
            String bauthor=txtAuthor.Text;
            String publication=txtPublication.Text;
            String pdate=dateTimePicker1.Text;
            Int64 price=Int64.Parse(txtBookPrice.Text);
            Int64 quan=Int64.Parse(txtBookQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=MUHAMMAD-JUNAID\\SQLEXPRESS;database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data savessed", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtBookPrice.Clear();
            txtBookQuantity.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete your unsaved Data.","Are you sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        
        }
    }
}
