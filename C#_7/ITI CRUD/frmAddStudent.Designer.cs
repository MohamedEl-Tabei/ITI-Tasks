namespace ITI_CRUD
{
    partial class frmAddStudent
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
            label1 = new Label();
            txtFName = new TextBox();
            cbDepartment = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtLName = new TextBox();
            label4 = new Label();
            Address = new Label();
            txtAddress = new TextBox();
            txtAge = new NumericUpDown();
            btnAdd = new Button();
            txtStatus = new Label();
            cbStudents = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 91);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(16, 114);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(267, 27);
            txtFName.TabIndex = 2;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(16, 293);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(267, 28);
            cbDepartment.TabIndex = 0;
            cbDepartment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 270);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 91);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(314, 114);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(267, 27);
            txtLName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 180);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 1;
            label4.Text = "Age";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(16, 180);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 1;
            Address.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(16, 203);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(267, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(314, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(267, 27);
            txtAge.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(189, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(267, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(189, 386);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(0, 20);
            txtStatus.TabIndex = 5;
            // 
            // cbStudents
            // 
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new Point(16, 23);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new Size(589, 28);
            cbStudents.TabIndex = 7;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(cbStudents);
            Controls.Add(txtStatus);
            Controls.Add(btnAdd);
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
            Name = "frmAddStudent";
            Text = "frmAddStudent";
            Load += frmAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFName;
        private ComboBox cbDepartment;
        private Label label3;
        private Label label2;
        private TextBox txtLName;
        private Label label4;
        private Label Address;
        private TextBox txtAddress;
        private NumericUpDown txtAge;
        private Button btnAdd;
        private Label txtStatus;
        private ComboBox cbStudents;
    }
}