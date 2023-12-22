using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            string EmployeeName;
            string Password;

            EmployeeName = txtEmployeeName.Text;
            Password = txtPassword.Text;

          
            








            }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtEmployeeName.Text;
            string password = txtPassword.Text;

            if (EmployeeName == "ramindi" && password == "123")
            {
                MessageBox.Show("Login success!");
                frmDetails f2 = new frmDetails();
                this.Hide();
                f2 .Show();

            }
            else
            {
                MessageBox.Show("Login not success!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

