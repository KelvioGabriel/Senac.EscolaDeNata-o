namespace Escola.Natação.Work1
{
    public partial class FormSelecionarOpcao : Form
    {
        public FormSelecionarOpcao()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            FormCadastroAlunos formAlunos = new FormCadastroAlunos();
            formAlunos.ShowDialog();
        }

        private void btnMarcarAula_Click(object sender, EventArgs e)
        {
            FormMarcacaoAulas formAulas = new FormMarcacaoAulas();
            formAulas.ShowDialog();
        }
    }
}