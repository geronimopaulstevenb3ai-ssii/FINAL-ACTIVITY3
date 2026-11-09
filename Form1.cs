using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check empty fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT COUNT(*) FROM [Users] " +
                        "WHERE [Username] = ? AND [Password] = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        // Access uses positional parameters
                        cmd.Parameters.AddWithValue(
                            "@Username", txtUsername.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Password", txtPassword.Text);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Login successful!",
                                "Welcome"
                            );

                            Form3 dashboard = new Form3();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Incorrect username or password.",
                                "Login Failed"
                            );

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login Error: " + ex.Message
                );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 DashboardForm = new Form3();
            DashboardForm.Show();
            this.Hide();
        }
    }
}