using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FooDrinK.UserControls
{
    public partial class UC_AddItemsWindow : UserControl
    {
        DataManage Item_Data = new DataManage();
        string query;
        public UC_AddItemsWindow()
        {
            InitializeComponent();
        }
        public void CloseAll()
        {
            Category_Box.SelectedIndex = -1;
            Item_Name_Box.Clear();
            Price_Box.Clear();
            NewItemName_Box.Clear();
            NewPrice_Box.Clear();
            Update_G_Box.Hide();
            Add_Box.Checked = false;
            Remove_Box.Checked = false;
            Update_Box.Checked = false;
        }
        public void Check_Box_Changed(object sender,EventArgs e)
        {
            var V = (CheckBox)sender;
            if (V.Name == Update_Box.Name)
            {
                if (V.Checked)
                {
                    Add_Box.Checked = false;
                    Remove_Box.Checked = false;
                    Update_G_Box.Show();
                }
                else
                {
                    Update_G_Box.Hide();
                }
            }
            else if (V.Name == Add_Box.Name)
            {
                if (V.Checked)
                {
                    Remove_Box.Checked = false;
                    Update_Box.Checked = false;
                }
            }
            else if (V.Name == Remove_Box.Name)
            {
                if (V.Checked)
                {
                    Add_Box.Checked = false;
                    Update_Box.Checked = false;
                }
            }
        }
        private void Modify_btn_Click(object sender, EventArgs e)
        {
            if (Add_Box.Checked)
            {
                query = "insert into Item (Name,Price,Category) values ('" + Item_Name_Box.Text + "'," + Price_Box.Text + ",'" + Category_Box.Text + "')";
                Item_Data.setData(query);
                CloseAll();
            }
            else if (Remove_Box.Checked)
            {
                query = "delete from Item where Name ='" + Item_Name_Box.Text + "'";
                Item_Data.setData(query);
                CloseAll();
            }
            else if (Update_Box.Checked)
            {
                query = "update Item set Name='"+NewItemName_Box.Text+"',Price="+NewPrice_Box.Text+" where Name='"+Item_Name_Box.Text+"'";
                Item_Data.setData(query);
                CloseAll();
            }
        }

        private void UC_AddItemsWindow_Load(object sender, EventArgs e)
        {
            Update_G_Box.Hide();
        }
    }
}
