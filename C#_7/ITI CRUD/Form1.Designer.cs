namespace ITI_CRUD
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
            gridStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridStudent).BeginInit();
            SuspendLayout();
            // 
            // gridStudent
            // 
            gridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudent.Dock = DockStyle.Fill;
            gridStudent.Location = new Point(0, 0);
            gridStudent.Name = "gridStudent";
            gridStudent.RowHeadersWidth = 51;
            gridStudent.Size = new Size(800, 450);
            gridStudent.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridStudent);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridStudent;
    }
}
