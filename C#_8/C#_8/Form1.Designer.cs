namespace C__8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridStudents = new DataGridView();
            txtStatus = new Label();
            btnSync = new Button();
            txtAge = new NumericUpDown();
            txtAddress = new TextBox();
            Address = new Label();
            txtLName = new TextBox();
            label4 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cbDepartment = new ComboBox();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(12, 12);
            gridStudents.Name = "gridStudents";
            gridStudents.RowHeadersWidth = 51;
            gridStudents.Size = new Size(776, 165);
            gridStudents.TabIndex = 0;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(308, 351);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(0, 20);
            txtStatus.TabIndex = 30;
            // 
            // btnSync
            // 
            btnSync.BackColor = Color.SteelBlue;
            btnSync.ForeColor = Color.White;
            btnSync.Location = new Point(308, 397);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(177, 29);
            btnSync.TabIndex = 29;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = false;
            btnSync.Click += btnSync_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(308, 280);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(267, 27);
            txtAge.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(10, 280);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(267, 27);
            txtAddress.TabIndex = 24;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(10, 257);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 19;
            Address.Text = "Address";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(308, 213);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(267, 27);
            txtLName.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 257);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 20;
            label4.Text = "Age";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(10, 213);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(267, 27);
            txtFName.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 190);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 21;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 320);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 22;
            label3.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 190);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 23;
            label1.Text = "First Name";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(10, 343);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(267, 28);
            cbDepartment.TabIndex = 18;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SeaGreen;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(12, 397);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(177, 29);
            btnInsert.TabIndex = 29;
            btnInsert.Text = "Insert Student";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(btnInsert);
            Controls.Add(btnSync);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(Address);
            Controls.Add(txtLName);
            Controls.Add(label4);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbDepartment);
            Controls.Add(gridStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridStudents;
        private Label txtStatus;
        private Button btnSync;
        private NumericUpDown txtAge;
        private TextBox txtAddress;
        private Label Address;
        private TextBox txtLName;
        private Label label4;
        private TextBox txtFName;
        private Label label2;
        private Label label3;
        private Label label1;
        private ComboBox cbDepartment;
        private Button btnInsert;
    }
}
