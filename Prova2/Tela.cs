namespace Prova2
{
    public partial class Tela : Form
    {
        public Tela()
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