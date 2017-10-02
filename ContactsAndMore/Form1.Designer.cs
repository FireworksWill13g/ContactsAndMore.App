namespace ContactsAndMore
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.Label();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ContactsAndMore_ContactsSqliteDBDataSet = new ContactsAndMore._ContactsAndMore_ContactsSqliteDBDataSet();
            this.addToDb = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateMonthlyPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleTableAdapter = new ContactsAndMore._ContactsAndMore_ContactsSqliteDBDataSetTableAdapters.PeopleTableAdapter();
            this.contactsAndMoreContactsSqliteDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.CalMoPayPanel = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoanAmount = new System.Windows.Forms.ComboBox();
            this.APR = new System.Windows.Forms.ComboBox();
            this.LTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlyAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ContactsAndMore_ContactsSqliteDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsAndMoreContactsSqliteDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource2)).BeginInit();
            this.CalMoPayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(227, 105);
            this.FirstName.Margin = new System.Windows.Forms.Padding(6);
            this.FirstName.MaxLength = 50;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(153, 34);
            this.FirstName.TabIndex = 2;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(75, 107);
            this.fName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(149, 31);
            this.fName.TabIndex = 1;
            this.fName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(227, 162);
            this.LastName.Margin = new System.Windows.Forms.Padding(6);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(153, 34);
            this.LastName.TabIndex = 4;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(74, 164);
            this.LName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(146, 31);
            this.LName.TabIndex = 3;
            this.LName.Text = "LastName";
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(227, 217);
            this.e_mail.Margin = new System.Windows.Forms.Padding(6);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(153, 34);
            this.e_mail.TabIndex = 6;
            this.e_mail.TextChanged += new System.EventHandler(this.e_mail_TextChanged);
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.Location = new System.Drawing.Point(74, 221);
            this.eMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(86, 31);
            this.eMail.TabIndex = 5;
            this.eMail.Text = "EMail";
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToDeleteRows = false;
            this.peopleDataGridView.AutoGenerateColumns = false;
            this.peopleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.personEmailDataGridViewTextBoxColumn});
            this.peopleDataGridView.DataSource = this.peopleBindingSource;
            this.peopleDataGridView.Location = new System.Drawing.Point(94, 319);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.Size = new System.Drawing.Size(724, 298);
            this.peopleDataGridView.TabIndex = 6;
            this.peopleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.peopleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            this.personIDDataGridViewTextBoxColumn.Width = 142;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 154;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // personEmailDataGridViewTextBoxColumn
            // 
            this.personEmailDataGridViewTextBoxColumn.DataPropertyName = "PersonEmail";
            this.personEmailDataGridViewTextBoxColumn.HeaderText = "PersonEmail";
            this.personEmailDataGridViewTextBoxColumn.Name = "personEmailDataGridViewTextBoxColumn";
            this.personEmailDataGridViewTextBoxColumn.Width = 180;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this._ContactsAndMore_ContactsSqliteDBDataSet;
            // 
            // _ContactsAndMore_ContactsSqliteDBDataSet
            // 
            this._ContactsAndMore_ContactsSqliteDBDataSet.DataSetName = "_ContactsAndMore_ContactsSqliteDBDataSet";
            this._ContactsAndMore_ContactsSqliteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToDb
            // 
            this.addToDb.BackColor = System.Drawing.SystemColors.Control;
            this.addToDb.Location = new System.Drawing.Point(597, 98);
            this.addToDb.Name = "addToDb";
            this.addToDb.Size = new System.Drawing.Size(118, 35);
            this.addToDb.TabIndex = 7;
            this.addToDb.Text = "Add";
            this.addToDb.UseVisualStyleBackColor = false;
            this.addToDb.Click += new System.EventHandler(this.addToDb_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.SystemColors.Control;
            this.del.Location = new System.Drawing.Point(597, 154);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(118, 35);
            this.del.TabIndex = 8;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Location = new System.Drawing.Point(735, 154);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(115, 35);
            this.loadBtn.TabIndex = 9;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(735, 97);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 35);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.paymentCalculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // paymentCalculatorToolStripMenuItem
            // 
            this.paymentCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateMonthlyPaymentsToolStripMenuItem,
            this.calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem});
            this.paymentCalculatorToolStripMenuItem.Name = "paymentCalculatorToolStripMenuItem";
            this.paymentCalculatorToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.paymentCalculatorToolStripMenuItem.Text = "Payment Calculator";
            // 
            // calculateMonthlyPaymentsToolStripMenuItem
            // 
            this.calculateMonthlyPaymentsToolStripMenuItem.Name = "calculateMonthlyPaymentsToolStripMenuItem";
            this.calculateMonthlyPaymentsToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            this.calculateMonthlyPaymentsToolStripMenuItem.Text = "Calculate Monthly Payments";
            this.calculateMonthlyPaymentsToolStripMenuItem.Click += new System.EventHandler(this.calculateMonthlyPaymentsToolStripMenuItem_Click);
            // 
            // calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem
            // 
            this.calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem.Name = "calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem";
            this.calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            this.calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem.Text = "Calculate Loan amount from Desired Monthly Payment";
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // contactsAndMoreContactsSqliteDBDataSetBindingSource
            // 
            this.contactsAndMoreContactsSqliteDBDataSetBindingSource.DataSource = this._ContactsAndMore_ContactsSqliteDBDataSet;
            this.contactsAndMoreContactsSqliteDBDataSetBindingSource.Position = 0;
            // 
            // peopleBindingSource1
            // 
            this.peopleBindingSource1.DataMember = "People";
            this.peopleBindingSource1.DataSource = this.contactsAndMoreContactsSqliteDBDataSetBindingSource;
            // 
            // peopleBindingSource2
            // 
            this.peopleBindingSource2.DataMember = "People";
            this.peopleBindingSource2.DataSource = this._ContactsAndMore_ContactsSqliteDBDataSet;
            // 
            // CalMoPayPanel
            // 
            this.CalMoPayPanel.Controls.Add(this.monthlyAmount);
            this.CalMoPayPanel.Controls.Add(this.Clear);
            this.CalMoPayPanel.Controls.Add(this.Calculate);
            this.CalMoPayPanel.Controls.Add(this.label4);
            this.CalMoPayPanel.Controls.Add(this.LoanAmount);
            this.CalMoPayPanel.Controls.Add(this.APR);
            this.CalMoPayPanel.Controls.Add(this.LTerm);
            this.CalMoPayPanel.Controls.Add(this.label3);
            this.CalMoPayPanel.Controls.Add(this.label2);
            this.CalMoPayPanel.Controls.Add(this.label1);
            this.CalMoPayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalMoPayPanel.Location = new System.Drawing.Point(0, 28);
            this.CalMoPayPanel.Name = "CalMoPayPanel";
            this.CalMoPayPanel.Size = new System.Drawing.Size(935, 670);
            this.CalMoPayPanel.TabIndex = 12;
            this.CalMoPayPanel.Visible = false;
            this.CalMoPayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clear.Location = new System.Drawing.Point(260, 319);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(150, 47);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Calculate.Location = new System.Drawing.Point(74, 319);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(150, 47);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Payments";
            // 
            // LoanAmount
            // 
            this.LoanAmount.FormattingEnabled = true;
            this.LoanAmount.Location = new System.Drawing.Point(280, 47);
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Size = new System.Drawing.Size(121, 37);
            this.LoanAmount.TabIndex = 1;
            this.LoanAmount.SelectedIndexChanged += new System.EventHandler(this.LoanAmount_SelectedIndexChanged);
            // 
            // APR
            // 
            this.APR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APR.FormattingEnabled = true;
            this.APR.Location = new System.Drawing.Point(211, 116);
            this.APR.Name = "APR";
            this.APR.Size = new System.Drawing.Size(121, 33);
            this.APR.TabIndex = 2;
            this.APR.SelectedIndexChanged += new System.EventHandler(this.APR_SelectedIndexChanged);
            // 
            // LTerm
            // 
            this.LTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTerm.FormattingEnabled = true;
            this.LTerm.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48",
            "60",
            "72",
            "84",
            "96",
            "108",
            "120"});
            this.LTerm.Location = new System.Drawing.Point(210, 164);
            this.LTerm.Name = "LTerm";
            this.LTerm.Size = new System.Drawing.Size(121, 33);
            this.LTerm.TabIndex = 3;
            this.LTerm.Text = "Months";
            this.LTerm.SelectedIndexChanged += new System.EventHandler(this.LTerm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "APR %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Loan Amount";
            // 
            // monthlyAmount
            // 
            this.monthlyAmount.AutoSize = true;
            this.monthlyAmount.Location = new System.Drawing.Point(281, 233);
            this.monthlyAmount.Name = "monthlyAmount";
            this.monthlyAmount.Size = new System.Drawing.Size(99, 29);
            this.monthlyAmount.TabIndex = 10;
            this.monthlyAmount.Text = "$/Month";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 698);
            this.Controls.Add(this.CalMoPayPanel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.del);
            this.Controls.Add(this.addToDb);
            this.Controls.Add(this.peopleDataGridView);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ContactsAndMore_ContactsSqliteDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsAndMoreContactsSqliteDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource2)).EndInit();
            this.CalMoPayPanel.ResumeLayout(false);
            this.CalMoPayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.Button addToDb;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentCalculatorToolStripMenuItem;
        private _ContactsAndMore_ContactsSqliteDBDataSet _ContactsAndMore_ContactsSqliteDBDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private _ContactsAndMore_ContactsSqliteDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.BindingSource contactsAndMoreContactsSqliteDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.BindingSource peopleBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel CalMoPayPanel;
        private System.Windows.Forms.ComboBox LoanAmount;
        private System.Windows.Forms.ComboBox APR;
        private System.Windows.Forms.ComboBox LTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem calculateMonthlyPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateLoanAmountFromDesiredMonthlyPaymentToolStripMenuItem;
        private System.Windows.Forms.Label monthlyAmount;
    }
}

