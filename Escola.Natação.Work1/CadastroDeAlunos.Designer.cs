namespace Escola.Natação.Work1
{
    partial class FormCadastroAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDataNascimento = new DateTimePicker();
            btnCadastroAluno = new Button();
            cmbAreaAula = new ComboBox();
            txtNomeAluno = new TextBox();
            txtNumeroMatricula = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Do Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Data De Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 9);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 3;
            label4.Text = "Número Da Matricula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 89);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Area De Aula";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(12, 107);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(229, 23);
            dtpDataNascimento.TabIndex = 9;
            // 
            // btnCadastroAluno
            // 
            btnCadastroAluno.Location = new Point(471, 187);
            btnCadastroAluno.Name = "btnCadastroAluno";
            btnCadastroAluno.Size = new Size(75, 23);
            btnCadastroAluno.TabIndex = 10;
            btnCadastroAluno.Text = "Cadastrar";
            btnCadastroAluno.UseVisualStyleBackColor = true;
            btnCadastroAluno.Click += btnCadastroAluno_Click;
            // 
            // cmbAreaAula
            // 
            cmbAreaAula.DisplayMember = "AreaNatacao";
            cmbAreaAula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaAula.FormattingEnabled = true;
            cmbAreaAula.Items.AddRange(new object[] { "Aula De Natação", "Hidroginastica", "Natação Proficional" });
            cmbAreaAula.Location = new Point(317, 107);
            cmbAreaAula.Name = "cmbAreaAula";
            cmbAreaAula.Size = new Size(229, 23);
            cmbAreaAula.TabIndex = 11;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(12, 27);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(229, 23);
            txtNomeAluno.TabIndex = 5;
            // 
            // txtNumeroMatricula
            // 
            txtNumeroMatricula.Location = new Point(317, 27);
            txtNumeroMatricula.Mask = "0000000000";
            txtNumeroMatricula.Name = "txtNumeroMatricula";
            txtNumeroMatricula.Size = new Size(229, 23);
            txtNumeroMatricula.TabIndex = 12;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 187);
            txtTelefone.Mask = "(00) 0 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(229, 23);
            txtTelefone.TabIndex = 13;
            // 
            // FormCadastroAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 218);
            Controls.Add(txtTelefone);
            Controls.Add(txtNumeroMatricula);
            Controls.Add(cmbAreaAula);
            Controls.Add(btnCadastroAluno);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtNomeAluno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroAlunos";
            Text = "Cadastro De Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDataNascimento;
        private Button btnCadastroAluno;
        private ComboBox cmbAreaAula;
        private TextBox txtNomeAluno;
        private MaskedTextBox txtNumeroMatricula;
        private MaskedTextBox txtTelefone;
    }
}