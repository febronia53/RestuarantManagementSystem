
namespace FooDrinK
{
    partial class OrderWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo_lbl = new System.Windows.Forms.Label();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.Outside_btn = new System.Windows.Forms.Button();
            this.Inside_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModifyWindow = new FooDrinK.UserControls.UC_AddItemsWindow();
            this.OutsideWindow = new FooDrinK.UC_OutsideWindow();
            this.insideWindow = new FooDrinK.UC_InsideWindow();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.Logo_lbl);
            this.panel1.Controls.Add(this.Modify_btn);
            this.panel1.Controls.Add(this.Outside_btn);
            this.panel1.Controls.Add(this.Inside_btn);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 797);
            this.panel1.TabIndex = 0;
            // 
            // Logo_lbl
            // 
            this.Logo_lbl.AutoSize = true;
            this.Logo_lbl.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo_lbl.ForeColor = System.Drawing.Color.White;
            this.Logo_lbl.Location = new System.Drawing.Point(29, 750);
            this.Logo_lbl.Name = "Logo_lbl";
            this.Logo_lbl.Size = new System.Drawing.Size(109, 23);
            this.Logo_lbl.TabIndex = 6;
            this.Logo_lbl.Text = "FooDrinK";
            // 
            // Modify_btn
            // 
            this.Modify_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modify_btn.Location = new System.Drawing.Point(12, 239);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(162, 81);
            this.Modify_btn.TabIndex = 3;
            this.Modify_btn.Text = "Modify";
            this.Modify_btn.UseVisualStyleBackColor = true;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // Outside_btn
            // 
            this.Outside_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Outside_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Outside_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outside_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Outside_btn.Location = new System.Drawing.Point(12, 152);
            this.Outside_btn.Name = "Outside_btn";
            this.Outside_btn.Size = new System.Drawing.Size(162, 81);
            this.Outside_btn.TabIndex = 2;
            this.Outside_btn.Text = "OutSide";
            this.Outside_btn.UseVisualStyleBackColor = true;
            this.Outside_btn.Click += new System.EventHandler(this.Outside_btn_Click);
            // 
            // Inside_btn
            // 
            this.Inside_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Inside_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inside_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inside_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Inside_btn.Location = new System.Drawing.Point(12, 65);
            this.Inside_btn.Name = "Inside_btn";
            this.Inside_btn.Size = new System.Drawing.Size(163, 81);
            this.Inside_btn.TabIndex = 1;
            this.Inside_btn.Text = "InSide";
            this.Inside_btn.UseVisualStyleBackColor = true;
            this.Inside_btn.Click += new System.EventHandler(this.Inside_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Back_btn.Location = new System.Drawing.Point(0, 0);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(52, 42);
            this.Back_btn.TabIndex = 0;
            this.Back_btn.Text = "<";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.ModifyWindow);
            this.panel2.Controls.Add(this.OutsideWindow);
            this.panel2.Controls.Add(this.insideWindow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 797);
            this.panel2.TabIndex = 1;
            // 
            // ModifyWindow
            // 
            this.ModifyWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModifyWindow.Location = new System.Drawing.Point(0, 0);
            this.ModifyWindow.Name = "ModifyWindow";
            this.ModifyWindow.Size = new System.Drawing.Size(1353, 797);
            this.ModifyWindow.TabIndex = 2;
            // 
            // OutsideWindow
            // 
            this.OutsideWindow.AutoScroll = true;
            this.OutsideWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OutsideWindow.Location = new System.Drawing.Point(0, 0);
            this.OutsideWindow.Name = "OutsideWindow";
            this.OutsideWindow.Size = new System.Drawing.Size(1353, 797);
            this.OutsideWindow.TabIndex = 1;
            // 
            // insideWindow
            // 
            this.insideWindow.Location = new System.Drawing.Point(0, 0);
            this.insideWindow.Name = "insideWindow";
            this.insideWindow.Size = new System.Drawing.Size(1353, 797);
            this.insideWindow.TabIndex = 0;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1524, 797);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderWindow";
            this.Load += new System.EventHandler(this.OrderWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Modify_btn;
        private System.Windows.Forms.Button Outside_btn;
        private System.Windows.Forms.Button Inside_btn;
        private System.Windows.Forms.Label Logo_lbl;
        private UserControls.UC_AddItemsWindow ModifyWindow;
        private UC_OutsideWindow OutsideWindow;
        private UC_InsideWindow insideWindow;
    }
}