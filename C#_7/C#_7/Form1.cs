using System.Data;

namespace C__7
{
    public partial class frmCalculator : Form
    {
        private char LastClicked;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (LastClicked == '=') txtScreen.Clear();
            LastClicked = btn.Text[0];
            txtScreen.Text = $"{txtScreen.Text}{btn.Text}";
        }

        private void btnEquel_Click(object sender, EventArgs e)
        {
            try
            {
                LastClicked = '=';
                if (txtScreen.Text.Contains("÷0")) throw new Exception();
                var result = new DataTable().Compute(txtScreen.Text.Replace('×', '*').Replace('÷', '/'), null);
                txtScreen.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtScreen.Text = "Error";

            }
        }

        private void btnDeleteLast(object sender, EventArgs e)
        {
            if (txtScreen.Text == "Error") txtScreen.Clear(); 
            if(txtScreen.Text.Length > 0) txtScreen.Text=txtScreen.Text.Remove(txtScreen.Text.Length-1);
        }
    }
}
