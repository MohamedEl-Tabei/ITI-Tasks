namespace ITI_CRUD
{
    partial class frmDeleteUpdateStudent
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
            cbStudents = new ComboBox();
            txtStatus = new Label();
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
            cbDepartment = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // cbStudents
            // 
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new Point(12, 30);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new Size(776, 28);
            cbStudents.TabIndex = 0;
            cbStudents.SelectedIndexChanged += cbStudents_SelectedIndexChanged;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(501, 283);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(0, 20);
            txtStatus.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(100, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(267, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Student";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(398, 193);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(267, 27);
            txtAge.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(100, 193);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(267, 27);
            txtAddress.TabIndex = 12;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(100, 170);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 7;
            Address.Text = "Address";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(398, 104);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(267, 27);
            txtLName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 170);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(100, 104);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(267, 27);
            txtFName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 81);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 260);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 10;
            label3.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 81);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(100, 283);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(267, 28);
            cbDepartment.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(398, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(267, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDeleteUpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
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
            Controls.Add(cbStudents);
            Name = "frmDeleteUpdateStudent";
            Text = "frmDeleteUpdateStudent";
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStudents;
        private Label txtStatus;
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
        private ComboBox cbDepartment;
        private Button btnDelete;
    }
}