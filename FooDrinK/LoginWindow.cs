using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace FooDrinK
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Invisible_btn_Click(object sender, EventArgs e)
        {
            if (Password_txt.PasswordChar == '\0')
            {
                Password_txt.PasswordChar = '*';
                visible_btn.BringToFront();
            }
        }

        private void visible_btn_Click(object sender, EventArgs e)
        {
            if (Password_txt.PasswordChar == '*')
            {
                Password_txt.PasswordChar = '\0';
                Invisible_btn.BringToFront();
            }
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            visible_btn.BringToFront();
            Password_txt.PasswordChar = '*';
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Cashier_btn_Click(object sender, EventArgs e)
        {
            OrderWindow Win = new OrderWindow("guest");
            Win.Show();
            this.Close();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            if(Username_txt.Text!="admin" || Password_txt.Text != "admin")
            {
                MessageBox.Show("Wrong username or PassWord", "Error", MessageBoxButtons.OK);
                Username_txt.Clear();
                Password_txt.Clear();
            }
            else
            {
                OrderWindow Win = new OrderWindow("admin");
                Win.Show();
                this.Hide();
            }
        }

    }
}
