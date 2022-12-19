
namespace FooDrinK.UserControls
{
    partial class UC_AddItemsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Category_Box = new System.Windows.Forms.ComboBox();
            this.Add_Box = new System.Windows.Forms.CheckBox();
            this.Item_Name_Box = new System.Windows.Forms.TextBox();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.Update_Box = new System.Windows.Forms.CheckBox();
            this.Remove_Box = new System.Windows.Forms.CheckBox();
            this.Modify_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NewPrice_Box = new System.Windows.Forms.TextBox();
            this.NewItemName_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_G_Box = new System.Windows.Forms.GroupBox();
            this.Update_G_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(491, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(419, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operation Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(534, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(466, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name:";
            // 
            // Category_Box
            // 
            this.Category_Box.FormattingEnabled = true;
            this.Category_Box.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.Category_Box.Location = new System.Drawing.Point(624, 167);
            this.Category_Box.Name = "Category_Box";
            this.Category_Box.Size = new System.Drawing.Size(163, 24);
            this.Category_Box.TabIndex = 4;
            // 
            // Add_Box
            // 
            this.Add_Box.AutoSize = true;
            this.Add_Box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Add_Box.Location = new System.Drawing.Point(624, 327);
            this.Add_Box.Name = "Add_Box";
            this.Add_Box.Size = new System.Drawing.Size(58, 22);
            this.Add_Box.TabIndex = 5;
            this.Add_Box.Text = "Add";
            this.Add_Box.UseVisualStyleBackColor = true;
            this.Add_Box.CheckedChanged += new System.EventHandler(this.Check_Box_Changed);
            // 
            // Item_Name_Box
            // 
            this.Item_Name_Box.Location = new System.Drawing.Point(624, 219);
            this.Item_Name_Box.Name = "Item_Name_Box";
            this.Item_Name_Box.Size = new System.Drawing.Size(163, 24);
            this.Item_Name_Box.TabIndex = 8;
            // 
            // Price_Box
            // 
            this.Price_Box.Location = new System.Drawing.Point(624, 273);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.Size = new System.Drawing.Size(163, 24);
            this.Price_Box.TabIndex = 9;
            // 
            // Update_Box
            // 
            this.Update_Box.AutoSize = true;
            this.Update_Box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Update_Box.Location = new System.Drawing.Point(786, 327);
            this.Update_Box.Name = "Update_Box";
            this.Update_Box.Size = new System.Drawing.Size(83, 22);
            this.Update_Box.TabIndex = 10;
            this.Update_Box.Text = "Update";
            this.Update_Box.UseVisualStyleBackColor = true;
            this.Update_Box.CheckedChanged += new System.EventHandler(this.Check_Box_Changed);
            // 
            // Remove_Box
            // 
            this.Remove_Box.AutoSize = true;
            this.Remove_Box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Remove_Box.Location = new System.Drawing.Point(688, 327);
            this.Remove_Box.Name = "Remove_Box";
            this.Remove_Box.Size = new System.Drawing.Size(92, 22);
            this.Remove_Box.TabIndex = 11;
            this.Remove_Box.Text = "Remove";
            this.Remove_Box.UseVisualStyleBackColor = true;
            this.Remove_Box.CheckedChanged += new System.EventHandler(this.Check_Box_Changed);
            // 
            // Modify_btn
            // 
            this.Modify_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modify_btn.Location = new System.Drawing.Point(1102, 625);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(93, 54);
            this.Modify_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Modify_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Modify_btn.StateCommon.Border.Rounding = 15;
            this.Modify_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Modify_btn.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Modify_btn.StateNormal.Border.Rounding = 15;
            this.Modify_btn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Modify_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Modify_btn.StatePressed.Border.Rounding = 15;
            this.Modify_btn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Modify_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Modify_btn.StateTracking.Border.Rounding = 15;
            this.Modify_btn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.TabIndex = 13;
            this.Modify_btn.Values.Text = "Modify";
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // NewPrice_Box
            // 
            this.NewPrice_Box.Location = new System.Drawing.Point(221, 87);
            this.NewPrice_Box.Name = "NewPrice_Box";
            this.NewPrice_Box.Size = new System.Drawing.Size(163, 26);
            this.NewPrice_Box.TabIndex = 17;
            // 
            // NewItemName_Box
            // 
            this.NewItemName_Box.Location = new System.Drawing.Point(221, 33);
            this.NewItemName_Box.Name = "NewItemName_Box";
            this.NewItemName_Box.Size = new System.Drawing.Size(163, 26);
            this.NewItemName_Box.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "New Item Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(74, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "New Price:";
            // 
            // Update_G_Box
            // 
            this.Update_G_Box.Controls.Add(this.label5);
            this.Update_G_Box.Controls.Add(this.NewPrice_Box);
            this.Update_G_Box.Controls.Add(this.label6);
            this.Update_G_Box.Controls.Add(this.NewItemName_Box);
            this.Update_G_Box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_G_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Update_G_Box.Location = new System.Drawing.Point(406, 368);
            this.Update_G_Box.Name = "Update_G_Box";
            this.Update_G_Box.Size = new System.Drawing.Size(463, 158);
            this.Update_G_Box.TabIndex = 18;
            this.Update_G_Box.TabStop = false;
            this.Update_G_Box.Text = "Update Info";
            // 
            // UC_AddItemsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Update_G_Box);
            this.Controls.Add(this.Modify_btn);
            this.Controls.Add(this.Remove_Box);
            this.Controls.Add(this.Update_Box);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.Item_Name_Box);
            this.Controls.Add(this.Add_Box);
            this.Controls.Add(this.Category_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddItemsWindow";
            this.Size = new System.Drawing.Size(1353, 797);
            this.Load += new System.EventHandler(this.UC_AddItemsWindow_Load);
            this.Update_G_Box.ResumeLayout(false);
            this.Update_G_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Category_Box;
        private System.Windows.Forms.CheckBox Add_Box;
        private System.Windows.Forms.TextBox Item_Name_Box;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.CheckBox Update_Box;
        private System.Windows.Forms.CheckBox Remove_Box;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Modify_btn;
        private System.Windows.Forms.TextBox NewPrice_Box;
        private System.Windows.Forms.TextBox NewItemName_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Update_G_Box;
    }
}
