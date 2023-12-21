using ControleFinanceiro.Properties;

namespace ControleFinanceiro
{
    public partial class PGMain : Form
    {
        public PGMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divida mostrardiv=new Divida();
            this.Hide();
            mostrardiv.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Entrada lançamento=new Entrada();
            this.Hide();
            lançamento.ShowDialog();
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Periodo tempo=new Periodo();
            this.Hide();
            tempo.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            PGMain principal = new PGMain();
            this.Close();
        }
    }
}