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

namespace HW1___StudentInfo
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""StudentInfo - HW1"";Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [StudentInfo]";
            cmd.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            datagridRecords.DataSource = dta;
            datagridRecords2.DataSource = dta;

            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Login and logout Button Code
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form2 stu = new Form2();
            stu.Show();

            stu.LoginPanel.Visible = true;

            this.Hide();
        }

        //CRUD Button Code - Beginning
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE ID='" + textID.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                {
                    con.Close();
                    MessageBox.Show("This ID already exists");
                }
            else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [StudentInfo] (ID, First_Name, Last_Name, Program, Expec_Grad_Year) VALUES ('" + textID.Text + "','" + textFirstName.Text + "','" + textLastName.Text + "','" + textProgram.Text + "','" + textExpectedGrad.Text + "')";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    textID.Text = "";
                    textFirstName.Text = "";
                    textLastName.Text = "";
                    textProgram.Text = "";
                    textExpectedGrad.Text = "";

                    display_data();

                    MessageBox.Show("Data inserted successfully!");
                }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE [StudentInfo] SET First_Name='" + textFirstName.Text + "', Last_Name='" + textLastName.Text + "', Program='" + textProgram.Text + "', Expec_Grad_Year= '" + textExpectedGrad.Text + "' WHERE ID='" + textID.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();

            textID.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            textProgram.Text = "";
            textExpectedGrad.Text = "";

            buttonInsert.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = true;

            textID.Enabled = true;

            MessageBox.Show("Data updated successfully!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String message = "Are you sure want to delete this record?";
            String title = "Warning";

            MessageBoxButtons messageButton = MessageBoxButtons.OKCancel;
            MessageBoxIcon WarningIcon = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(message, title, messageButton, WarningIcon);

            if (result == DialogResult.OK)
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " DELETE FROM [StudentInfo] WHERE ID='" + textID.Text + "'";

                cmd.ExecuteNonQuery();
                con.Close();
                display_data();

                textID.Text = "";
                textFirstName.Text = "";
                textLastName.Text = "";
                textProgram.Text = "";
                textExpectedGrad.Text = "";

                buttonInsert.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;

                textID.Enabled = true;

                MessageBox.Show("Data deleted successfully!");
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            String srch = textSearch.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE First_Name Like '%" + srch + "%' OR Last_Name Like '%" + srch + "%' OR Program Like '%" + srch + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                datagridRecords.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("There is no record under this name. Please try again.");
                con.Close();
            }
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            display_data();
        }
        //CRUD Buttons Code - End

       
        // Data Grid Display Code - Beginning
        private void datagridRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = datagridRecords.Rows[myindex];

            String reg = row.Cells[0].Value.ToString();
            String value1 = row.Cells[0].Value.ToString();
            String value2 = row.Cells[0].Value.ToString();
            String value3 = row.Cells[0].Value.ToString();
            String value4 = row.Cells[0].Value.ToString();

            textID.Text = reg;
            textID.Enabled = false;

            textFirstName.Text = value1;
            textLastName.Text = value2;
            textProgram.Text = value3;
            textExpectedGrad.Text = value4;

            buttonInsert.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }
        // Data Grid Display Code - End

        //Login Panel - Beginning
        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            con.Open();

            String srch = textSearch2.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE First_Name Like '%" + srch + "%' OR Last_Name Like '%" + srch + "%' OR Program Like '%" + srch + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                datagridRecords2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("This record does not exist. Please try again.");
                con.Close();
            }
        }

        private void buttonRecords2_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void datagridRecords2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = datagridRecords2.Rows[myindex];

            String reg = row.Cells[0].Value.ToString();
            String value1 = row.Cells[0].Value.ToString();
            String value2 = row.Cells[0].Value.ToString();
            String value3 = row.Cells[0].Value.ToString();
            String value4 = row.Cells[0].Value.ToString();

            textID.Text = reg;
            textID.Enabled = false;

            textFirstName.Text = value1;
            textLastName.Text = value2;
            textProgram.Text = value3;
            textExpectedGrad.Text = value4;
        }
    }
}
