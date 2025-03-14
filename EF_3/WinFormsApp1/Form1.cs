using WinFormsApp1.Context;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ITIContext db=new ITIContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridStudents.EndEdit();
            db.SaveChanges();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            gridStudents.DataSource = db.Students.ToList();
        }
    }
}
