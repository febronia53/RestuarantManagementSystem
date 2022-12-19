using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FooDrinK
{
    public partial class OrderWindow : Form
    {
        public string User="";
        public OrderWindow()
        {
            InitializeComponent();
        }
        public OrderWindow(int Table_num)
        {
            InitializeComponent();
            insideWindow.Open_Table(Table_num);
            if (User == "guest")
            {
                Modify_btn.Hide();
            }
            else
            {
                Modify_btn.Show();
            }
        }
        public OrderWindow(string user)
        {
            InitializeComponent();
            User = user;
            if (User == "guest")
            {
                Modify_btn.Hide();
                insideWindow.Hide_Remove_btn();
            }
            else
            {
                Modify_btn.Show();
            }
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Log_in L = new Log_in();
            L.Show();
            this.Close();
        }
        private void Inside_btn_Click(object sender, EventArgs e)
        {
            insideWindow.BringToFront();
            Inside_btn.BackColor = Color.FromArgb(250, 255, 255);
            Inside_btn.ForeColor = Color.FromArgb(0, 80, 120);
            Outside_btn.BackColor = Color.FromArgb(0, 80, 120);
            Outside_btn.ForeColor = Color.FromArgb(250, 255, 255);
            Modify_btn.BackColor = Color.FromArgb(0, 80, 120);
            Modify_btn.ForeColor = Color.FromArgb(250, 255, 255);
        }
        private void Outside_btn_Click(object sender, EventArgs e)
        {
            OutsideWindow.BringToFront();
            Outside_btn.BackColor = Color.FromArgb(250, 255, 255);
            Outside_btn.ForeColor = Color.FromArgb(0, 80, 120);
            Inside_btn.BackColor = Color.FromArgb(0, 80, 120);
            Inside_btn.ForeColor = Color.FromArgb(250, 255, 255);
            Modify_btn.BackColor = Color.FromArgb(0, 80, 120);
            Modify_btn.ForeColor = Color.FromArgb(250, 255, 255);
        }
        private void Modify_btn_Click(object sender, EventArgs e)
        {
            ModifyWindow.BringToFront();
            Modify_btn.BackColor = Color.FromArgb(250, 255, 255);
            Modify_btn.ForeColor = Color.FromArgb(0, 80, 120);
            Inside_btn.BackColor = Color.FromArgb(0, 80, 120);
            Inside_btn.ForeColor = Color.FromArgb(250, 255, 255);
            Outside_btn.BackColor = Color.FromArgb(0, 80, 120);
            Outside_btn.ForeColor = Color.FromArgb(250, 255, 255);
        }
        private void OrderWindow_Load(object sender, EventArgs e)
        {
            Inside_btn.PerformClick();
            insideWindow.ShowTablesClick += (ss, ee) => {
                Tables_View T = new Tables_View();
                T.Show();
                this.Close();
            };
        }
    }
}
