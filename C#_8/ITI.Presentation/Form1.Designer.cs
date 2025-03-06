namespace ITI.Presentation
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
            txtStatus = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            txtAge = new NumericUpDown();
            txtAddress = new TextBox();
            Address = new Label();
            txtLName = new TextBox();
            label4 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            gridStudents = new DataGridView();
            txtDepartment = new TextBox();
            cbStudents = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(309, 357);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(0, 20);
            txtStatus.TabIndex = 44;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SeaGreen;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(13, 403);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(177, 29);
            btnInsert.TabIndex = 42;
            btnInsert.Text = "Insert Student";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(309, 403);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 29);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(309, 286);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(267, 27);
            txtAge.TabIndex = 41;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(11, 286);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(267, 27);
            txtAddress.TabIndex = 38;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(11, 263);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 33;
            Address.Text = "Address";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(309, 219);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(267, 27);
            txtLName.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 263);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 34;
            label4.Text = "Age";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(11, 219);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(267, 27);
            txtFName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 196);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 35;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 326);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 36;
            label3.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 196);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 37;
            label1.Text = "First Name";
            // 
            // gridStudents
            // 
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(13, 18);
            gridStudents.Name = "gridStudents";
            gridStudents.RowHeadersWidth = 51;
            gridStudents.Size = new Size(776, 165);
            gridStudents.TabIndex = 31;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(13, 357);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(267, 27);
            txtDepartment.TabIndex = 38;
            // 
            // cbStudents
            // 
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new Point(309, 369);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new Size(177, 28);
            cbStudents.TabIndex = 45;
            cbStudents.SelectedIndexChanged += cbStudents_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(612, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 29);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbStudents);
            Controls.Add(txtStatus);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAge);
            Controls.Add(txtDepartment);
            Controls.Add(txtAddress);
            Controls.Add(Address);
            Controls.Add(txtLName);
            Controls.Add(label4);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(gridStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStatus;
        private Button btnInsert;
        private Button btnUpdate;
        private NumericUpDown txtAge;
        private TextBox txtAddress;
        private Label Address;
        private TextBox txtLName;
        private Label label4;
        private TextBox txtFName;
        private Label label2;
        private Label label3;
        private Label label1;
        private DataGridView gridStudents;
        private TextBox txtDepartment;
        private ComboBox cbStudents;
        private Button btnDelete;
    }
}
