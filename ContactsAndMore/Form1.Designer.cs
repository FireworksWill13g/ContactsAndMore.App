﻿namespace ContactsAndMore
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
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ContactsAndMore_ContactsSqliteDBDataSet = new ContactsAndMore._ContactsAndMore_ContactsSqliteDBDataSet();
            this.addToDb = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleTableAdapter = new ContactsAndMore._ContactsAndMore_ContactsSqliteDBDataSetTableAdapters.PeopleTableAdapter();
            this.contactsAndMoreContactsSqliteDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ContactsAndMore_ContactsSqliteDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsAndMoreContactsSqliteDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource2)).BeginInit();
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
            // 
            // paymentCalculatorToolStripMenuItem
            // 
            this.paymentCalculatorToolStripMenuItem.Name = "paymentCalculatorToolStripMenuItem";
            this.paymentCalculatorToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.paymentCalculatorToolStripMenuItem.Text = "Payment Calculator";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 698);
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
    }
}

