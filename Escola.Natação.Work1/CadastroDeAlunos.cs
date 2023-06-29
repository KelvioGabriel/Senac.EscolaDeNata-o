using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Natação.Work1
{
    public partial class FormCadastroAlunos : Form
    {
        List<Aluno> alunos = new List<Aluno>();
        public FormCadastroAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoCadastrado = new Aluno();

            alunoCadastrado.NomeAluno = txtNomeAluno.Text;
            alunoCadastrado.DataNascimento = dtpDataNascimento.Value;
            alunoCadastrado.NumeroMatricula = txtNumeroMatricula.Text;
            alunoCadastrado.Telefone = txtTelefone.Text;
            alunoCadastrado.AreaAula = Convert.ToString(cmbAreaAula.SelectedIndex);

            MessageBox.Show("O Aluno " + alunoCadastrado.NomeAluno + " foi cadastrado");
            alunos.Add(alunoCadastrado);
        }
    }
}
