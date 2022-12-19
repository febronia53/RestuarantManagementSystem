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
    public partial class UC_InsideWindow : UserControl
    {
        DataManage ItemData = new DataManage();
        public event EventHandler ShowTablesClick = null;
        string query, check_num = "";
        int table_num = -1;
        double Check_Total = 0;
        public UC_InsideWindow()
        {
            InitializeComponent();
        }
        public void Hide_Remove_btn()
        {
            Remove_btn.Hide();
        }
        public void Open_Table(int num)
        {
            Table_Num_Box.Text = num.ToString();
            if (table_num >= 1 && table_num <= 10)
            {
                query = "delete from One_line_in_Check where exists(select * from One_line_in_Check where check_no=" + check_num + "and sent=0)and check_no=" + check_num + "and sent=0";
                ItemData.setData(query);
            }
            table_num = convert(Table_Num_Box.Text);
            if (table_num >= 1 && table_num <= 10)
            {
                Check_Data_Grid.Rows.Clear();
                DataSet DS = new DataSet();
                query = "select * from [Check] where Table_no= " + table_num + " And Opened=1";
                DS = ItemData.getData(query);
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    check_num = DS.Tables[0].Rows[0][0].ToString();
                    query = "select * from One_line_in_Check where check_no=" + check_num + "";
                    DS = ItemData.getData(query);
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        Check_Data_Grid.Rows.Add(DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString());
                    }
                }
                else
                {
                    check_num = "0";
                }
                Calculate_Total();
            }
            else
            {
                MessageBox.Show("Please Choose from 1 to 10");
                Table_Num_Box.Clear();
            }
        }
        public void Calculate_Total()
        {
            double Total = 0;
            DataSet DS = new DataSet();
            query = "select * from One_line_in_Check where check_no=" + check_num + "";
            DS = ItemData.getData(query);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    double price = double.Parse(DS.Tables[0].Rows[i][4].ToString());
                    Total += price;
                }
            }
            Check_Total = Total;
            DS.Tables.Clear();
            query = "select * from [Check] where Check_no =" + check_num + "";
            DS = ItemData.getData(query);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                double Disscount = Convert.ToDouble(DS.Tables[0].Rows[0][1].ToString());
                Total -= (Total * (Disscount / 100.0));
            }
            Total = Math.Round(Total);
            Total_Num_lbl.Text = "$ " + Total.ToString();
        }
        public void Update_Check()
        {
            Check_Data_Grid.Rows.Clear();
            DataSet DS = new DataSet();
            query = "select * from One_line_in_Check where check_no=" + check_num + "";
            DS = ItemData.getData(query);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (Convert.ToInt32(DS.Tables[0].Rows[i][5]) == 1)
                        Check_Data_Grid.Rows.Add(DS.Tables[0].Rows[i][2].ToString() + " *", DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString());
                    else
                        Check_Data_Grid.Rows.Add(DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString());
                }
            }
        }
        public void Fill_Flow(object sender,EventArgs e)
        {
            Show_Panel.Controls.Clear();
            DataSet DS = new DataSet();
            var V = (Button)sender;
            query = "select * from Item where Category = '" + V.Text + "'";
            DS = ItemData.getData(query);
            for(int i=0;i<DS.Tables[0].Rows.Count;i++)
            {
                UC_Item Item = new UC_Item();
                Item.Plus_Select += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "select * from [Check] where Table_no=" + table_num + " and Opened=1";
                        DataSet opened = new DataSet();
                        opened = ItemData.getData(query);
                        if(opened.Tables.Count == 0 || opened.Tables[0].Rows.Count == 0)
                        {
                            opened.Tables.Clear();
                            query = "insert into [Check] (Table_no,Total,Opened) values (" + table_num + ",0,1)";
                            ItemData.setData(query);
                            query = "select * from [Check] where Table_no=" + table_num + " and Opened=1";
                            opened = ItemData.getData(query);
                            check_num = opened.Tables[0].Rows[0][0].ToString();
                            query = "update [Table] set Status = 'nonempty'where Table_no=" + table_num + "";
                            ItemData.setData(query);
                        }
                        query = "select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        DataSet Ok = new DataSet();
                        Ok = ItemData.getData(query);
                        if (Ok.Tables.Count > 0 && Ok.Tables[0].Rows.Count>0)
                        {
                            int amount = int.Parse(Ok.Tables[0].Rows[0][3].ToString());
                            amount++;
                            double total = Convert.ToDouble(Item.price.ToString());
                            total *= amount;
                            query = "update One_line_in_Check" +
                            " set Amount=" + amount + ",Price=" + total + "" +
                            " where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                            ItemData.setData(query);
                        }
                        else
                        {
                            query = "insert into One_line_in_Check(check_no,Item_no,Item_Name,Amount,Price,sent)" +
                            "Values (" + check_num + "," + Item.id + ",'" + Item.name + "',1," + Item.price + ",0)";
                            ItemData.setData(query);
                        }
                        Update_Check();
                        Calculate_Total();
                    }
                };
                Item.Mins_Select += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        DataSet Ok = new DataSet();
                        Ok = ItemData.getData(query);
                        if (Ok.Tables.Count > 0 && Ok.Tables[0].Rows.Count > 0)
                        {
                            int amount = int.Parse(Ok.Tables[0].Rows[0][3].ToString());
                            amount--;
                            if (amount > 0)
                            {
                                double total = Convert.ToDouble(Item.price.ToString());
                                total *= amount;
                                query = "update One_line_in_Check" +
                                " set Amount=" + amount + ",Price=" + total + "" +
                                " where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                                ItemData.setData(query);
                            }
                            else
                            {
                                query = "delete from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + "and sent=0";
                                ItemData.setData(query);
                            }
                        }
                        
                        Update_Check();
                        Calculate_Total();
                    }
                };
                Item.Comment_Changed += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "update One_line_in_Check set Comment= '" + Item.comment + "'" +
                        " where exists (select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0) and" +
                        "check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        ItemData.setData(query);
                    }

                };
                Item.setValues(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString());
                Show_Panel.Controls.Add(Item);

            }
        }
        private void Food_btn_Click(object sender, EventArgs e)
        {
            Fill_Flow(sender,e);
            Food_btn.ForeColor = Color.FromArgb(250,255,255);
            Drink_btn.ForeColor = Color.FromArgb(0, 40, 80);
        }
        private void Drink_btn_Click(object sender, EventArgs e)
        {
            Fill_Flow(sender, e);
            Drink_btn.ForeColor = Color.FromArgb(250, 255, 255);
            Food_btn.ForeColor = Color.FromArgb(0, 40, 80);
        }
        public int convert(string s)
        {
            if (s.Length > 2)
                return (int)-1;
            int x = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                    x = x * 10 + (s[i] - '0');
                else
                    return (int)-1;
            }
            return x;
        }
        private void Send_btn_Click(object sender, EventArgs e)
        {
            query = "update One_line_in_Check set sent = 1 where check_no=" + check_num + " and sent = 0";
            ItemData.setData(query);
        }
        private void Print_btn_Click(object sender, EventArgs e)
        {
            Offers_Box.Hide();
            Percentage.Hide();
            Offer_lbl.Text = "% 0";
            query = "update [Check] set Opened = 0 , Total = "+Check_Total+" where Check_no=" + check_num + " and  Opened= 1";
            ItemData.setData(query);
            check_num = "0";
            Update_Check();
            Calculate_Total();
            query = "update [Table] set Status = 'empty' where Table_no=" + table_num + "";
            ItemData.setData(query);
        }
        private void Show_Tables_btn_Click(object sender, EventArgs e)
        {
            ShowTablesClick?.Invoke(this, e);
        }
        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            Food_btn.ForeColor = Color.FromArgb(0, 40, 80);
            Drink_btn.ForeColor = Color.FromArgb(0, 40, 80);
            Show_Panel.Controls.Clear();
            query = "select * from Item where Name like'%" + Search_Box.Text + "%'";
            DataSet DS = new DataSet();
            DS = ItemData.getData(query);
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                UC_Item Item = new UC_Item();
                Item.Plus_Select += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "select * from [Check] where Table_no=" + table_num + " and Opened=1";
                        DataSet opened = new DataSet();
                        opened = ItemData.getData(query);
                        if (opened.Tables.Count == 0 || opened.Tables[0].Rows.Count == 0)
                        {
                            opened.Tables.Clear();
                            query = "insert into [Check] (Table_no,Total,Opened) values (" + table_num + ",0,1)";
                            ItemData.setData(query);
                            query = "select * from [Check] where Table_no=" + table_num + " and Opened=1";
                            opened = ItemData.getData(query);
                            check_num = opened.Tables[0].Rows[0][0].ToString();
                            query = "update [Table] set Status = 'nonempty'where Table_no=" + table_num + "";
                            ItemData.setData(query);
                        }
                        query = "select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        DataSet Ok = new DataSet();
                        Ok = ItemData.getData(query);
                        if (Ok.Tables.Count > 0 && Ok.Tables[0].Rows.Count > 0)
                        {
                            int amount = int.Parse(Ok.Tables[0].Rows[0][3].ToString());
                            amount++;
                            double total = Convert.ToDouble(Item.price.ToString());
                            total *= amount;
                            query = "update One_line_in_Check" +
                            " set Amount=" + amount + ",Price=" + total + "" +
                            " where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                            ItemData.setData(query);
                        }
                        else
                        {
                            query = "insert into One_line_in_Check(check_no,Item_no,Item_Name,Amount,Price,sent)" +
                            "Values (" + check_num + "," + Item.id + ",'" + Item.name + "',1," + Item.price + ",0)";
                            ItemData.setData(query);
                        }
                        Update_Check();
                        Calculate_Total();
                    }
                };
                Item.Mins_Select += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        DataSet Ok = new DataSet();
                        Ok = ItemData.getData(query);
                        if (Ok.Tables.Count > 0 && Ok.Tables[0].Rows.Count > 0)
                        {
                            int amount = int.Parse(Ok.Tables[0].Rows[0][3].ToString());
                            amount--;
                            if (amount > 0)
                            {
                                double total = Convert.ToDouble(Item.price.ToString());
                                total *= amount;
                                query = "update One_line_in_Check" +
                                " set Amount=" + amount + ",Price=" + total + "" +
                                " where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                                ItemData.setData(query);
                            }
                            else
                            {
                                query = "delete from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + "and sent=0";
                                ItemData.setData(query);
                            }
                        }

                        Update_Check();
                        Calculate_Total();
                    }
                };
                Item.Comment_Changed += (ss, ee) =>
                {
                    if (table_num == -1)
                    {
                        MessageBox.Show("enter Table Number first");
                    }
                    else
                    {
                        query = "update One_line_in_Check set Comment= '" + Item.comment + "'" +
                        " where exists (select * from One_line_in_Check where check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0) and" +
                        "check_no=" + check_num + " and Item_no=" + Item.id + " and sent=0";
                        ItemData.setData(query);
                    }

                };
                Item.setValues(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString());
                Show_Panel.Controls.Add(Item);

            }
        }
        private void UC_InsideWindow_Load(object sender, EventArgs e)
        {
            Offers_Box.Hide();
            Percentage.Hide();
        }
        private void Offers_btn_Click(object sender, EventArgs e)
        {
            Offers_Box.Show();
            Percentage.Show();
        }
        private void Offers_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Offer_lbl.Text = "% " + Offers_Box.Text;
                query = "update [Check] set Offers =" + Offers_Box.Text + " where Check_no=" + check_num + "";
                ItemData.setData(query);
                Calculate_Total();
                Offers_Box.Hide();
                Percentage.Hide();
            }
        }
        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Check_Data_Grid.SelectedRows.Count > 0)
            {
                string s = Check_Data_Grid.SelectedRows[0].Cells[0].Value.ToString();
                if (s[s.Length - 1] == '*')
                {
                    string s1 = "";
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        s1 += s[i];
                    }
                    query = "delete from One_line_in_Check where check_no=" + check_num + " and Item_Name='" + s1 + "' and sent = 1";
                    ItemData.setData(query);
                    Calculate_Total();
                    Update_Check();
                }
                else
                {
                    query = "delete from One_line_in_Check where check_no=" + check_num + " and Item_Name='" + s + "' and sent = 0";
                    ItemData.setData(query);
                    Calculate_Total();
                    Update_Check();
                }
            }
            else
            {
                MessageBox.Show("Please choose item from check by Clicking on > in left side");
            }
        }
        private void Table_Num_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            Total_Num_lbl.Text = "$ 0";
            if (e.KeyChar == (char)13)
            {
                if (table_num >= 1 && table_num <= 10) {
                    query = "delete from One_line_in_Check where exists(select * from One_line_in_Check where check_no=" + check_num + "and sent=0)and check_no=" + check_num + "and sent=0";
                    ItemData.setData(query);
                }
                table_num = convert(Table_Num_Box.Text);
                if (table_num >= 1 && table_num <= 10)
                {
                    Check_Data_Grid.Rows.Clear();
                    DataSet DS = new DataSet();
                    query = "select * from [Check] where Table_no= " + table_num + " And Opened=1";
                    DS = ItemData.getData(query);
                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        check_num = DS.Tables[0].Rows[0][0].ToString();
                        query = "select * from One_line_in_Check where check_no=" + check_num + "";
                        DS = ItemData.getData(query);
                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            Check_Data_Grid.Rows.Add(DS.Tables[0].Rows[i][2].ToString() + " *", DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString());
                        }
                    }
                    else
                    {
                        check_num = "0";
                    }
                    Calculate_Total();
                }
                else
                {
                    MessageBox.Show("Please Choose from 1 to 10");
                    Table_Num_Box.Clear();
                }
            }
        }
    }
}
