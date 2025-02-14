namespace Lern_Oeriode_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spiel spielForm = new Spiel(); 
            spielForm.Show();              
            this.Hide();
        }
    }
}
