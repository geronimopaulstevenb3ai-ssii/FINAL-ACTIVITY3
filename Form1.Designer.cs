namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
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
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(238, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Khaki;
            linkLabel1.Location = new Point(21, 336);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 290);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 7;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(21, 189);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(171, 23);
            txtUsername.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(21, 227);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 5;
            label5.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(21, 167);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 4;
            label4.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(21, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 3;
            label3.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(126, 63);
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
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(366, 31);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Log in form";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}
