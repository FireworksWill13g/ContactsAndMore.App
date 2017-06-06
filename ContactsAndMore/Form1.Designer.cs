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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addToDb = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(205, 105);
            this.FirstName.Margin = new System.Windows.Forms.Padding(6);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(153, 29);
            this.FirstName.TabIndex = 0;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(75, 107);
            this.fName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(119, 25);
            this.fName.TabIndex = 1;
            this.fName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(205, 162);
            this.LastName.Margin = new System.Windows.Forms.Padding(6);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(153, 29);
            this.LastName.TabIndex = 2;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(74, 164);
            this.LName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(117, 25);
            this.LName.TabIndex = 3;
            this.LName.Text = "LastName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 217);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.Location = new System.Drawing.Point(74, 221);
            this.eMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(71, 25);
            this.eMail.TabIndex = 5;
            this.eMail.Text = "EMail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 298);
            this.dataGridView1.TabIndex = 6;
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.paymentCalculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2085, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // paymentCalculatorToolStripMenuItem
            // 
            this.paymentCalculatorToolStripMenuItem.Name = "paymentCalculatorToolStripMenuItem";
            this.paymentCalculatorToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.paymentCalculatorToolStripMenuItem.Text = "Payment Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2085, 1045);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.del);
            this.Controls.Add(this.addToDb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addToDb;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentCalculatorToolStripMenuItem;
    }
}

