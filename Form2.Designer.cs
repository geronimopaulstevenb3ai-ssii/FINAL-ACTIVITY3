namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textConfirmPassword = new TextBox();
            textPassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            textUsername = new TextBox();
            textFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(textConfirmPassword);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(textUsername);
            groupBox1.Controls.Add(textFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(126, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Location = new Point(288, 240);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(167, 23);
            textConfirmPassword.TabIndex = 11;
            textConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(288, 165);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(167, 23);
            textPassword.TabIndex = 10;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPasword_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Khaki;
            label7.Location = new Point(288, 218);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 9;
            label7.Text = "Re-Enter Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(288, 143);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Khaki;
            btnRegister.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(21, 294);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(104, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "SIGN UP";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(21, 240);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(171, 23);
            textUsername.TabIndex = 6;
            textUsername.TextChanged += textBox2_TextChanged;
            // 
            // textFullName
            // 
            textFullName.Location = new Point(21, 165);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(171, 23);
            textFullName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(21, 218);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 5;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(21, 143);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 4;
            label4.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(23, 110);
            label3.Name = "label3";
            label3.Size = new Size(224, 23);
            label3.TabIndex = 3;
            label3.Text = "CREATE AN ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(204, 50);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 2;
            label2.Text = "SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(89, 19);
            label1.Name = "label1";
            label1.Size = new Size(366, 31);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Registration form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegister;
        private TextBox textUsername;
        private TextBox textFullName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textConfirmPassword;
        private TextBox textPassword;
        private Label label7;
        private Label label6;
    }
}