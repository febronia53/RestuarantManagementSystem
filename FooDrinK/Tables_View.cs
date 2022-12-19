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
    public partial class Tables_View : Form
    {
        DataManage ItemData = new DataManage();
        string query;
        public Tables_View()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tables_View_Load(object sender, EventArgs e)
        {
            query = "select * from [Table]";
            DataSet DS = new DataSet();
            DS = ItemData.getData(query);
            for(int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                Button T = new Button();
                T.Text = DS.Tables[0].Rows[i][0].ToString();
                T.Size = new Size(110, 90);
                if (DS.Tables[0].Rows[i][1].ToString() == "empty")
                {
                    T.BackColor = Color.FromArgb(250,255,255);
                    T.ForeColor = Color.FromArgb(0, 80, 120);
                }
                else
                {
                    T.BackColor = Color.FromArgb(0, 80, 120);
                    T.ForeColor = Color.FromArgb(250, 255, 255);
                }
                T.Click += (ss, ee) =>
                {
                    OrderWindow Win = new OrderWindow(Convert.ToInt32(T.Text));
                    Win.Show();
                    this.Close();
                };
                Tables_flow_Layout.Controls.Add(T);
            }
        }
    }
}
