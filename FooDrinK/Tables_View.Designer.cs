
namespace FooDrinK
{
    partial class Tables_View
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
            this.Header_panel = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Tables_flow_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Header_panel.Controls.Add(this.Close_btn);
            this.Header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_panel.Location = new System.Drawing.Point(0, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(1090, 49);
            this.Header_panel.TabIndex = 0;
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Close_btn.Location = new System.Drawing.Point(1032, -1);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(59, 50);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Tables_flow_Layout
            // 
            this.Tables_flow_Layout.AutoScroll = true;
            this.Tables_flow_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tables_flow_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tables_flow_Layout.Location = new System.Drawing.Point(0, 49);
            this.Tables_flow_Layout.Name = "Tables_flow_Layout";
            this.Tables_flow_Layout.Size = new System.Drawing.Size(1090, 728);
            this.Tables_flow_Layout.TabIndex = 1;
            // 
            // Tables_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 777);
            this.Controls.Add(this.Tables_flow_Layout);
            this.Controls.Add(this.Header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables_View";
            this.Load += new System.EventHandler(this.Tables_View_Load);
            this.Header_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.FlowLayoutPanel Tables_flow_Layout;
    }
}