using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom
{
    partial class MainForm
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

        private void LoadForm(Form form)
        {
            if (this.ParentPanel.Controls.Count > 0)
            {
                this.ParentPanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ParentPanel.Controls.Add(f);
            this.ParentPanel.Tag = f;
            f.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FooterSection = new System.Windows.Forms.Panel();
            this.SideBarSection = new System.Windows.Forms.Panel();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.SideBarSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // FooterSection
            // 
            this.FooterSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FooterSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterSection.Location = new System.Drawing.Point(0, 422);
            this.FooterSection.Name = "FooterSection";
            this.FooterSection.Size = new System.Drawing.Size(800, 28);
            this.FooterSection.TabIndex = 0;
            // 
            // SideBarSection
            // 
            this.SideBarSection.BackColor = System.Drawing.Color.White;
            this.SideBarSection.Controls.Add(this.ClientsButton);
            this.SideBarSection.Controls.Add(this.DashboardButton);
            this.SideBarSection.Controls.Add(this.panel1);
            this.SideBarSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarSection.Location = new System.Drawing.Point(0, 0);
            this.SideBarSection.Name = "SideBarSection";
            this.SideBarSection.Size = new System.Drawing.Size(150, 422);
            this.SideBarSection.TabIndex = 1;
            // 
            // ParentPanel
            // 
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(150, 0);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(650, 422);
            this.ParentPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 71);
            this.panel1.TabIndex = 0;
            // 
            // DashboardButton
            // 
            this.DashboardButton.AutoSize = true;
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(0, 71);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(150, 29);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.AutoSize = true;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.Location = new System.Drawing.Point(0, 100);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(150, 29);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.SideBarSection);
            this.Controls.Add(this.FooterSection);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Loan Management System By Josuan";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SideBarSection.ResumeLayout(false);
            this.SideBarSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FooterSection;
        private System.Windows.Forms.Panel SideBarSection;
        private System.Windows.Forms.Panel ParentPanel;
        private Panel panel1;
        private Button DashboardButton;
        private Button ClientsButton;
    }
}

