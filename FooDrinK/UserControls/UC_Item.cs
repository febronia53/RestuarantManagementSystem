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
    public partial class UC_Item : UserControl
    {
        public event EventHandler Plus_Select = null;
        public event EventHandler Mins_Select = null;
        public event EventHandler Comment_Changed = null;
        public string id, name, price, comment = "";
        public UC_Item()
        {
            InitializeComponent();
        }
        public void setValues(string i,string n,string p)
        {
            id = i;
            name = n;
            price = p;
            Item_Name_lbl.Text = n;
            Item_Price_lbl.Text = "$ " + p;
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            Plus_Select?.Invoke(this, e);
        }

        private void Mins_btn_Click(object sender, EventArgs e)
        {
            Mins_Select?.Invoke(this, e);
        }

        private void Comment_Box_TextChanged(object sender, EventArgs e)
        {
            Comment_Changed?.Invoke(this, e);
        }
    }
}
