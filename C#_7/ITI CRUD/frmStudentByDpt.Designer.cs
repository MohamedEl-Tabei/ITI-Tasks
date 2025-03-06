namespace ITI_CRUD
{
    partial class frmStudentByDpt
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
            cbDepartment = new ComboBox();
            Department = new Label();
            gridStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            SuspendLayout();
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(12, 32);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(151, 28);
            cbDepartment.TabIndex = 0;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(12, 9);
            Department.Name = "Department";
            Department.Size = new Size(89, 20);
            Department.TabIndex = 1;
            Department.Text = "Department";
            // 
            // gridStudents
            // 
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(12, 87);
            gridStudents.Name = "gridStudents";
            gridStudents.RowHeadersWidth = 51;
            gridStudents.Size = new Size(776, 351);
            gridStudents.TabIndex = 2;
            //gridStudents.CellContentClick += gridStudents_CellContentClick;
            // 
            // frmStudentByDpt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridStudents);
            Controls.Add(Department);
            Controls.Add(cbDepartment);
            Name = "frmStudentByDpt";
            Text = "frmStudentByDpt";
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDepartment;
        private Label Department;
        private DataGridView gridStudents;
    }
}