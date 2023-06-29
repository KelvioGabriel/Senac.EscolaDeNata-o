namespace Escola.Natação.Work1
{
    partial class FormSelecionarOpcao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMarcarAula = new Button();
            btnCadastrarAluno = new Button();
            SuspendLayout();
            // 
            // btnMarcarAula
            // 
            btnMarcarAula.Location = new Point(162, 12);
            btnMarcarAula.Name = "btnMarcarAula";
            btnMarcarAula.Size = new Size(85, 23);
            btnMarcarAula.TabIndex = 1;
            btnMarcarAula.Text = "Marcar Aulas";
            btnMarcarAula.UseVisualStyleBackColor = true;
            btnMarcarAula.Click += btnMarcarAula_Click;
            // 
            // btnCadastrarAluno
            // 
            btnCadastrarAluno.Location = new Point(26, 12);
            btnCadastrarAluno.Name = "btnCadastrarAluno";
            btnCadastrarAluno.Size = new Size(100, 23);
            btnCadastrarAluno.TabIndex = 2;
            btnCadastrarAluno.Text = "Cadastrar Aluno";
            btnCadastrarAluno.UseVisualStyleBackColor = true;
            btnCadastrarAluno.Click += btnCadastrarAluno_Click;
            // 
            // FormSelecionarOpcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 47);
            Controls.Add(btnCadastrarAluno);
            Controls.Add(btnMarcarAula);
            MaximizeBox = false;
            Name = "FormSelecionarOpcao";
            Text = "Cadastros De Aluno E Aulas";
            ResumeLayout(false);
        }

        #endregion
        private Button btnMarcarAula;
        private Button btnCadastrarAluno;
    }
}