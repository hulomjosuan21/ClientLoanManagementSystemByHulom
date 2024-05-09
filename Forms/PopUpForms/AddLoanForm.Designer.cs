using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    partial class AddLoanForm
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

        //this.LoanAmountTextBox
        //this.InterestTextBox
        //this.NoOfPaymentTextBox
        //this.InsuranceTextBox
        //this.OthersTextBox
        private void InitializeAddedComponent()
        {
            this.LoanAmountTextBox.TextChanged += new System.EventHandler(this.InputChanges);
            this.InterestTextBox.TextChanged += new System.EventHandler(this.InputChanges);
            this.NoOfPaymentTextBox.TextChanged += new System.EventHandler(this.InputChanges);
            this.InsuranceTextBox.TextChanged += new System.EventHandler(this.InputChanges);
            this.OthersTextBox.TextChanged += new System.EventHandler(this.InputChanges);

            this.LoanAmountTextBox.KeyPress += new KeyPressEventHandler(AddLoanForm
                .CatchNonNumericInput);
            this.InterestTextBox.KeyPress += new KeyPressEventHandler(AddLoanForm
                .CatchNonNumericInput);
            this.NoOfPaymentTextBox.KeyPress += new KeyPressEventHandler(AddLoanForm
                .CatchNonNumericInput);
            this.InsuranceTextBox.KeyPress += new KeyPressEventHandler(AddLoanForm
                .CatchNonNumericInput);
            this.OthersTextBox.KeyPress += new KeyPressEventHandler(AddLoanForm
                .CatchNonNumericInput);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.OthersTextBox = new System.Windows.Forms.TextBox();
            this.InsuranceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.TermComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InterestTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoanAmountTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AmountsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.OthersTextBox);
            this.panel1.Controls.Add(this.InsuranceTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NoOfPaymentTextBox);
            this.panel1.Controls.Add(this.TermComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InterestTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoanAmountTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 184);
            this.panel1.TabIndex = 0;
            // 
            // OthersTextBox
            // 
            this.OthersTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersTextBox.Location = new System.Drawing.Point(212, 152);
            this.OthersTextBox.Name = "OthersTextBox";
            this.OthersTextBox.Size = new System.Drawing.Size(139, 27);
            this.OthersTextBox.TabIndex = 12;
            // 
            // InsuranceTextBox
            // 
            this.InsuranceTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceTextBox.Location = new System.Drawing.Point(34, 152);
            this.InsuranceTextBox.Name = "InsuranceTextBox";
            this.InsuranceTextBox.Size = new System.Drawing.Size(172, 27);
            this.InsuranceTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Others";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deduction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. Of Payment";
            // 
            // NoOfPaymentTextBox
            // 
            this.NoOfPaymentTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfPaymentTextBox.Location = new System.Drawing.Point(212, 83);
            this.NoOfPaymentTextBox.Name = "NoOfPaymentTextBox";
            this.NoOfPaymentTextBox.Size = new System.Drawing.Size(139, 27);
            this.NoOfPaymentTextBox.TabIndex = 6;
            // 
            // TermComboBox
            // 
            this.TermComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermComboBox.FormattingEnabled = true;
            this.TermComboBox.Location = new System.Drawing.Point(16, 83);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(190, 27);
            this.TermComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interest";
            // 
            // InterestTextBox
            // 
            this.InterestTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestTextBox.Location = new System.Drawing.Point(212, 31);
            this.InterestTextBox.Name = "InterestTextBox";
            this.InterestTextBox.Size = new System.Drawing.Size(139, 27);
            this.InterestTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan Amount";
            // 
            // LoanAmountTextBox
            // 
            this.LoanAmountTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanAmountTextBox.Location = new System.Drawing.Point(16, 31);
            this.LoanAmountTextBox.Name = "LoanAmountTextBox";
            this.LoanAmountTextBox.Size = new System.Drawing.Size(190, 27);
            this.LoanAmountTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.AmountsLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CancelButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(357, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 184);
            this.panel2.TabIndex = 1;
            // 
            // AmountsLabel
            // 
            this.AmountsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AmountsLabel.Location = new System.Drawing.Point(142, 9);
            this.AmountsLabel.Name = "AmountsLabel";
            this.AmountsLabel.Size = new System.Drawing.Size(109, 140);
            this.AmountsLabel.TabIndex = 18;
            this.AmountsLabel.Text = "0\r\n0\r\n0\r\n\r\n0";
            this.AmountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 140);
            this.label8.TabIndex = 17;
            this.label8.Text = "Loan Amount:\r\nReceivable Amount:\r\nDeduction:\r\nDue Date:\r\nTotal Payable:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(125, 152);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 31);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(0, 152);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 31);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 184);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(627, 223);
            this.MinimumSize = new System.Drawing.Size(627, 223);
            this.Name = "AddLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddLoanForm";
            this.Load += new System.EventHandler(this.AddLoanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoanAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InterestTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoOfPaymentTextBox;
        private System.Windows.Forms.ComboBox TermComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OthersTextBox;
        private System.Windows.Forms.TextBox InsuranceTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AmountsLabel;
        private System.Windows.Forms.Label label8;
    }
}