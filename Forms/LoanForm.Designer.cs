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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.StatusButton = new System.Windows.Forms.Button();
            this.LoanTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
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
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(24)))));
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
            this.StatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(146)))), ((int)(((byte)(227)))));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Loan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(55, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "999";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.loanCol.DefaultCellStyle = dataGridViewCellStyle13;
            this.loanCol.HeaderText = "Loan Amount";
            this.loanCol.Name = "loanCol";
            this.loanCol.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
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
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.deductionCol.DefaultCellStyle = dataGridViewCellStyle14;
            this.deductionCol.HeaderText = "Deduction";
            this.deductionCol.Name = "deductionCol";
            this.deductionCol.ReadOnly = true;
            // 
            // interestedCol
            // 
            this.interestedCol.DataPropertyName = "InterestedAmount";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.interestedCol.DefaultCellStyle = dataGridViewCellStyle15;
            this.interestedCol.HeaderText = "Interested Amount";
            this.interestedCol.Name = "interestedCol";
            this.interestedCol.ReadOnly = true;
            // 
            // receivableCol
            // 
            this.receivableCol.DataPropertyName = "ReceivableAmount";
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.receivableCol.DefaultCellStyle = dataGridViewCellStyle16;
            this.receivableCol.HeaderText = "Receivable Amount";
            this.receivableCol.Name = "receivableCol";
            this.receivableCol.ReadOnly = true;
            // 
            // totalPayableCol
            // 
            this.totalPayableCol.DataPropertyName = "TotalPayable";
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.totalPayableCol.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            this.paidStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.paidStatusDataGridViewTextBoxColumn.HeaderText = "Loan Status";
            this.paidStatusDataGridViewTextBoxColumn.Name = "paidStatusDataGridViewTextBoxColumn";
            this.paidStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(ClientLoanManagementSystemByHulom.Entities.Loan);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Payable";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(262, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "999";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1322, 560);
            this.Controls.Add(this.LoanTable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1338, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1338, 599);
            this.Name = "LoanForm";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView LoanTable;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.BindingSource loanBindingSource;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}