using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HW1___StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Login Button
        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""StudentInfo - HW1"";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username='" + textUsername.Text + "' and Password='" + textPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 stu = new Form2();
                stu.Show();

                stu.LoginPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Either incorrect username or password. Please try again.");
            }

            con.Close();
        }
    }
}