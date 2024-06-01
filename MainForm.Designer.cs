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
            this.Text = f.Text;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FooterSection = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.SideBarSection = new System.Windows.Forms.Panel();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.HeaderSection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FooterSection.SuspendLayout();
            this.SideBarSection.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // FooterSection
            // 
            this.FooterSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.FooterSection.Controls.Add(this.FooterLabel);
            this.FooterSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterSection.Location = new System.Drawing.Point(0, 502);
            this.FooterSection.Name = "FooterSection";
            this.FooterSection.Size = new System.Drawing.Size(994, 18);
            this.FooterSection.TabIndex = 0;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterLabel.ForeColor = System.Drawing.Color.White;
            this.FooterLabel.Location = new System.Drawing.Point(0, 0);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(994, 18);
            this.FooterLabel.TabIndex = 0;
            this.FooterLabel.Text = "Client Loan Management System v1.0. Created By: ";
            this.FooterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarSection
            // 
            this.SideBarSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.SideBarSection.Controls.Add(this.ClientsButton);
            this.SideBarSection.Controls.Add(this.DashboardButton);
            this.SideBarSection.Controls.Add(this.panel1);
            this.SideBarSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarSection.Location = new System.Drawing.Point(0, 36);
            this.SideBarSection.Name = "SideBarSection";
            this.SideBarSection.Size = new System.Drawing.Size(150, 466);
            this.SideBarSection.TabIndex = 1;
            // 
            // ClientsButton
            // 
            this.ClientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsButton.AutoSize = true;
            this.ClientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.ClientsButton.Location = new System.Drawing.Point(0, 145);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(150, 29);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "MEMBERS";
            this.ClientsButton.UseVisualStyleBackColor = false;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardButton.AutoSize = true;
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.DashboardButton.Location = new System.Drawing.Point(0, 108);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(8);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(150, 29);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "HOME";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(116)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParentPanel
            // 
            this.ParentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(150, 36);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(844, 466);
            this.ParentPanel.TabIndex = 2;
            // 
            // HeaderSection
            // 
            this.HeaderSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(137)))));
            this.HeaderSection.Controls.Add(this.label1);
            this.HeaderSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderSection.Location = new System.Drawing.Point(0, 0);
            this.HeaderSection.Name = "HeaderSection";
            this.HeaderSection.Size = new System.Drawing.Size(994, 36);
            this.HeaderSection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT LOAN MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(994, 520);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.SideBarSection);
            this.Controls.Add(this.HeaderSection);
            this.Controls.Add(this.FooterSection);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1010, 559);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Josuan Leonardo Hulom BSIT 2A";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FooterSection.ResumeLayout(false);
            this.SideBarSection.ResumeLayout(false);
            this.SideBarSection.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FooterSection;
        private System.Windows.Forms.Panel SideBarSection;
        private System.Windows.Forms.Panel ParentPanel;
        private Button DashboardButton;
        private Button ClientsButton;
        private Panel HeaderSection;
        private Label label1;
        private Label FooterLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}

