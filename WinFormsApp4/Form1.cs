using WinFormsApp4.reutilizaveis;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



        private void buscarRacasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaRaca br = new BuscaRaca();
            ExibeForm.ExibirFormularioEmPainel(br, panel1);
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favoritos fv = new Favoritos();
            ExibeForm.ExibirFormularioEmPainel(fv, panel1);
        }
    }
}