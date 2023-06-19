namespace Prova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void br_Servico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            servico.ShowDialog();
        }
    }
}