using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show(
                        "Database Connected Successfully!",
                        "Connection Test"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Connection Failed"
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textPasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
    
            string fullName = textFullName.Text.Trim();
            string username = textUsername.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;

            
            if (fullName == "" || username == "" ||
                password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

           
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                textConfirmPassword.Clear();
                textConfirmPassword.Focus();
                return;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM [Users] WHERE [Username] = ?";

                    using (OleDbCommand checkCmd =
                        new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", username);

                        int count = Convert.ToInt32(
                            checkCmd.ExecuteScalar()
                        );

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists.");
                            textUsername.Focus();
                            return;
                        }
                    }

                    string insertQuery =
                        "INSERT INTO [Users] " +
                        "([FullName], [Username], [Password], [CreatedAt]) " +
                        "VALUES (?, ?, ?, ?)";

                    using (OleDbCommand cmd =
                        new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", fullName);
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);
                        cmd.Parameters.AddWithValue("?", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Registration successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                  
                    textFullName.Clear();
                    textUsername.Clear();
                    textPassword.Clear();
                    textConfirmPassword.Clear();

                
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
