
namespace C__7
{
    partial class frmCalculator
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
            txtScreen = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDivision = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btnEquel = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplication = new Button();
            btnMod = new Button();
            btnBack = new Button();
            btnPoint = new Button();
            btnMinus = new Button();
            SuspendLayout();
            // 
            // txtScreen
            // 
            txtScreen.BackColor = SystemColors.Window;
            txtScreen.Dock = DockStyle.Top;
            txtScreen.Enabled = false;
            txtScreen.Font = new Font("Segoe UI", 20F);
            txtScreen.Location = new Point(0, 0);
            txtScreen.Name = "txtScreen";
            txtScreen.ReadOnly = true;
            txtScreen.Size = new Size(482, 52);
            txtScreen.TabIndex = 0;
            txtScreen.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16F);
            btn1.Location = new Point(11, 284);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16F);
            btn2.Location = new Point(167, 284);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 50);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16F);
            btn3.Location = new Point(323, 284);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 50);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnClick;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.SteelBlue;
            btnDivision.Font = new Font("Segoe UI", 16F);
            btnDivision.ForeColor = Color.Transparent;
            btnDivision.Location = new Point(11, 60);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(150, 50);
            btnDivision.TabIndex = 1;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16F);
            btn4.Location = new Point(11, 228);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 50);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16F);
            btn5.Location = new Point(167, 228);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 50);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnClick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16F);
            btn6.Location = new Point(323, 228);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 50);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(11, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnClick;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16F);
            btn0.Location = new Point(11, 340);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnClick;
            // 
            // btnEquel
            // 
            btnEquel.BackColor = Color.SteelBlue;
            btnEquel.Font = new Font("Segoe UI", 16F);
            btnEquel.ForeColor = Color.Transparent;
            btnEquel.Location = new Point(323, 340);
            btnEquel.Name = "btnEquel";
            btnEquel.Size = new Size(150, 50);
            btnEquel.TabIndex = 1;
            btnEquel.Text = "=";
            btnEquel.UseVisualStyleBackColor = false;
            btnEquel.Click += btnEquel_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16F);
            btn7.Location = new Point(11, 172);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 50);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16F);
            btn8.Location = new Point(167, 172);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 50);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16F);
            btn9.Location = new Point(323, 172);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 50);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnClick;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.SteelBlue;
            btnMultiplication.Font = new Font("Segoe UI", 16F);
            btnMultiplication.ForeColor = Color.Transparent;
            btnMultiplication.Location = new Point(323, 116);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(150, 50);
            btnMultiplication.TabIndex = 1;
            btnMultiplication.Text = "×";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnClick;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.SteelBlue;
            btnMod.Font = new Font("Segoe UI", 16F);
            btnMod.ForeColor = Color.Transparent;
            btnMod.Location = new Point(167, 60);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(150, 50);
            btnMod.TabIndex = 1;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Segoe UI", 16F);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(323, 60);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnDeleteLast;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 16F);
            btnPoint.Location = new Point(167, 340);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(150, 50);
            btnPoint.TabIndex = 1;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnClick;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.SteelBlue;
            btnMinus.Font = new Font("Segoe UI", 16F);
            btnMinus.ForeColor = Color.Transparent;
            btnMinus.Location = new Point(167, 116);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(150, 50);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnClick;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(482, 402);
            Controls.Add(btnMultiplication);
            Controls.Add(btnBack);
            Controls.Add(btnMod);
            Controls.Add(btnEquel);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(btnDivision);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btnPoint);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtScreen);
            MinimumSize = new Size(500, 400);
            Name = "frmCalculator";
            Opacity = 0.99D;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtScreen;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDivision;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnAdd;
        private Button btn0;
        private Button btnEquel;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplication;
        private Button btnMod;
        private Button btnBack;
        private Button btnPoint;
        private Button btnMinus;
    }
}
