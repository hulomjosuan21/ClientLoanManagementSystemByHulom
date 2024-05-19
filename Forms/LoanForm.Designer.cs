using System;
using System.Globalization;

namespace ClientLoanManagementSystemByHulom.Forms
{
    partial class LoanForm
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

        private void InitializeAddedComponent()
        {
            FormatColumn("loanCol");
            FormatColumn("deductionCol");
            FormatColumn("interestedCol");
            FormatColumn("receivableCol");
            FormatColumn("totalPayableCol");
        }

        private void FormatColumn(string columnName)
        {
            this.LoanTable.Columns[columnName].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo(CURRENCY);
            this.LoanTable.Columns[columnName].DefaultCellStyle.Format = "C";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.StatusButton = new System.Windows.Forms.Button();
            this.LoanTable = new System.Windows.Forms.DataGridView();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivableCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayableCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalReceivableLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPayableLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ongoingLoansLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterOption = new System.Windows.Forms.ComboBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FullValueFormatToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.StatusButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 525);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(1306, 35);
            this.panel2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(146)))), ((int)(((byte)(227)))));
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(1072, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 27);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.StatusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusButton.FlatAppearance.BorderSize = 0;
            this.StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton.ForeColor = System.Drawing.Color.White;
            this.StatusButton.Location = new System.Drawing.Point(1187, 4);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(115, 27);
            this.StatusButton.TabIndex = 6;
            this.StatusButton.Text = "SET STATUS";
            this.StatusButton.UseVisualStyleBackColor = false;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // LoanTable
            // 
            this.LoanTable.AllowUserToAddRows = false;
            this.LoanTable.AllowUserToDeleteRows = false;
            this.LoanTable.AutoGenerateColumns = false;
            this.LoanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoanTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.LoanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.loanCol,
            this.interestDataGridViewTextBoxColumn,
            this.noOfPaymentsDataGridViewTextBoxColumn,
            this.paymentTermDataGridViewTextBoxColumn,
            this.deductionCol,
            this.interestedCol,
            this.receivableCol,
            this.totalPayableCol,
            this.dueDateDataGridViewTextBoxColumn,
            this.paidStatusDataGridViewTextBoxColumn});
            this.LoanTable.DataSource = this.loanBindingSource;
            this.LoanTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoanTable.Location = new System.Drawing.Point(8, 35);
            this.LoanTable.Name = "LoanTable";
            this.LoanTable.ReadOnly = true;
            this.LoanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LoanTable.Size = new System.Drawing.Size(1306, 490);
            this.LoanTable.TabIndex = 2;
            this.LoanTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LoanTable_CellFormatting);
            this.LoanTable.SelectionChanged += new System.EventHandler(this.LoanTable_SelectionChanged);
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "Loan ID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanCol
            // 
            this.loanCol.DataPropertyName = "LoanAmount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.loanCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.loanCol.HeaderText = "Loan Amount";
            this.loanCol.Name = "loanCol";
            this.loanCol.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.interestDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfPaymentsDataGridViewTextBoxColumn
            // 
            this.noOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "NoOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.HeaderText = "No of Payments";
            this.noOfPaymentsDataGridViewTextBoxColumn.Name = "noOfPaymentsDataGridViewTextBoxColumn";
            this.noOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTermDataGridViewTextBoxColumn
            // 
            this.paymentTermDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.HeaderText = "Payment Term";
            this.paymentTermDataGridViewTextBoxColumn.Name = "paymentTermDataGridViewTextBoxColumn";
            this.paymentTermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionCol
            // 
            this.deductionCol.DataPropertyName = "Deduction";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.deductionCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.deductionCol.HeaderText = "Deduction";
            this.deductionCol.Name = "deductionCol";
            this.deductionCol.ReadOnly = true;
            // 
            // interestedCol
            // 
            this.interestedCol.DataPropertyName = "InterestedAmount";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.interestedCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.interestedCol.HeaderText = "Interested Amount";
            this.interestedCol.Name = "interestedCol";
            this.interestedCol.ReadOnly = true;
            // 
            // receivableCol
            // 
            this.receivableCol.DataPropertyName = "ReceivableAmount";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.receivableCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.receivableCol.HeaderText = "Receivable Amount";
            this.receivableCol.Name = "receivableCol";
            this.receivableCol.ReadOnly = true;
            // 
            // totalPayableCol
            // 
            this.totalPayableCol.DataPropertyName = "TotalPayable";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.totalPayableCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalPayableCol.HeaderText = "Total Payable";
            this.totalPayableCol.Name = "totalPayableCol";
            this.totalPayableCol.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidStatusDataGridViewTextBoxColumn
            // 
            this.paidStatusDataGridViewTextBoxColumn.DataPropertyName = "PaidStatus";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.paidStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.paidStatusDataGridViewTextBoxColumn.HeaderText = "Loan Status";
            this.paidStatusDataGridViewTextBoxColumn.Name = "paidStatusDataGridViewTextBoxColumn";
            this.paidStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(ClientLoanManagementSystemByHulom.Entities.Loan);
            // 
            // totalReceivableLabel
            // 
            this.totalReceivableLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalReceivableLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReceivableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.totalReceivableLabel.Location = new System.Drawing.Point(441, 4);
            this.totalReceivableLabel.Name = "totalReceivableLabel";
            this.totalReceivableLabel.Size = new System.Drawing.Size(48, 27);
            this.totalReceivableLabel.TabIndex = 5;
            this.totalReceivableLabel.Text = "3";
            this.totalReceivableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(353, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Receivable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPayableLabel
            // 
            this.totalPayableLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalPayableLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.totalPayableLabel.Location = new System.Drawing.Point(566, 4);
            this.totalPayableLabel.Name = "totalPayableLabel";
            this.totalPayableLabel.Size = new System.Drawing.Size(48, 27);
            this.totalPayableLabel.TabIndex = 3;
            this.totalPayableLabel.Text = "2";
            this.totalPayableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(489, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Payable";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalLoanLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.totalLoanLabel.Location = new System.Drawing.Point(305, 4);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(48, 27);
            this.totalLoanLabel.TabIndex = 1;
            this.totalLoanLabel.Text = "1";
            this.totalLoanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(244, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Loan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ongoingLoansLabel
            // 
            this.ongoingLoansLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ongoingLoansLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongoingLoansLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.ongoingLoansLabel.Location = new System.Drawing.Point(729, 4);
            this.ongoingLoansLabel.Name = "ongoingLoansLabel";
            this.ongoingLoansLabel.Size = new System.Drawing.Size(48, 27);
            this.ongoingLoansLabel.TabIndex = 6;
            this.ongoingLoansLabel.Text = "4";
            this.ongoingLoansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(614, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Ongoing Loans";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FilterOption);
            this.panel1.Controls.Add(this.ongoingLoansLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.totalPayableLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalReceivableLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalLoanLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(1306, 35);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(1107, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "View Option";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterOption
            // 
            this.FilterOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterOption.FormattingEnabled = true;
            this.FilterOption.Location = new System.Drawing.Point(1178, 7);
            this.FilterOption.Name = "FilterOption";
            this.FilterOption.Size = new System.Drawing.Size(121, 21);
            this.FilterOption.TabIndex = 9;
            this.FilterOption.SelectedIndexChanged += new System.EventHandler(this.FilterOption_SelectedIndexChanged);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchTextbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.Location = new System.Drawing.Point(60, 4);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(184, 27);
            this.SearchTextbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullValueFormatToolTip
            // 
            this.FullValueFormatToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1322, 560);
            this.Controls.Add(this.LoanTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1041, 302);
            this.Name = "LoanForm";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.ResizeEnd += new System.EventHandler(this.LoanForm_ResizeEnd);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView LoanTable;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPayableLabel;
        private System.Windows.Forms.Label totalReceivableLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ongoingLoansLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FilterOption;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivableCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayableCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip FullValueFormatToolTip;
    }
}