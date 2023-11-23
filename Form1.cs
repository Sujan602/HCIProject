namespace WinFormsApp5
{
    public partial class frmMainform : Form
    {
        public frmMainform()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f2 = new frmLogin();
            f2.ShowDialog(); // Shows Form2
        }
    }
}