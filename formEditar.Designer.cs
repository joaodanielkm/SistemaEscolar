namespace Sistema_Escolar
{
    partial class formEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditar));
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbContatoNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbContatoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbMatricula = new System.Windows.Forms.MaskedTextBox();
            this.cbxNaturalidade = new System.Windows.Forms.ComboBox();
            this.cbxNacionalidade = new System.Windows.Forms.ComboBox();
            this.txbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Gold;
            this.btnAltera.Location = new System.Drawing.Point(624, 265);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(147, 41);
            this.btnAltera.TabIndex = 0;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Aqua;
            this.btnLimpar.Location = new System.Drawing.Point(624, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 41);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(624, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(147, 41);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(184, 37);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(436, 20);
            this.txbNome.TabIndex = 4;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexo.Location = new System.Drawing.Point(184, 92);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(132, 21);
            this.cbxSexo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "EMAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nacionalidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Naturaridade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CEP";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(26, 214);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(518, 20);
            this.txbEndereco.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cidade";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(463, 150);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(308, 20);
            this.txbCidade.TabIndex = 23;
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(26, 364);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(552, 62);
            this.txbObs.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Contato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Telefone";
            // 
            // txbContatoNome
            // 
            this.txbContatoNome.Location = new System.Drawing.Point(269, 306);
            this.txbContatoNome.Name = "txbContatoNome";
            this.txbContatoNome.Size = new System.Drawing.Size(309, 20);
            this.txbContatoNome.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Nome";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Observações";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(279, 150);
            this.txbCEP.Mask = "00000-999";
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(153, 20);
            this.txbCEP.TabIndex = 33;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(344, 91);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(200, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(561, 214);
            this.txbTelefone.Mask = "(99) 0 000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(210, 20);
            this.txbTelefone.TabIndex = 34;
            // 
            // txbContatoTelefone
            // 
            this.txbContatoTelefone.Location = new System.Drawing.Point(26, 306);
            this.txbContatoTelefone.Mask = "(99) 0 000-0000";
            this.txbContatoTelefone.Name = "txbContatoTelefone";
            this.txbContatoTelefone.Size = new System.Drawing.Size(210, 20);
            this.txbContatoTelefone.TabIndex = 35;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(26, 92);
            this.txbCPF.Mask = "000.000.000-99";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(132, 20);
            this.txbCPF.TabIndex = 36;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(26, 37);
            this.txbMatricula.Mask = "9999";
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.ReadOnly = true;
            this.txbMatricula.Size = new System.Drawing.Size(132, 20);
            this.txbMatricula.TabIndex = 37;
            this.txbMatricula.ValidatingType = typeof(int);
            // 
            // cbxNaturalidade
            // 
            this.cbxNaturalidade.FormattingEnabled = true;
            this.cbxNaturalidade.Location = new System.Drawing.Point(575, 92);
            this.cbxNaturalidade.Name = "cbxNaturalidade";
            this.cbxNaturalidade.Size = new System.Drawing.Size(196, 21);
            this.cbxNaturalidade.TabIndex = 38;
            // 
            // cbxNacionalidade
            // 
            this.cbxNacionalidade.FormattingEnabled = true;
            this.cbxNacionalidade.Location = new System.Drawing.Point(26, 149);
            this.cbxNacionalidade.Name = "cbxNacionalidade";
            this.cbxNacionalidade.Size = new System.Drawing.Size(233, 21);
            this.cbxNacionalidade.TabIndex = 39;
            // 
            // txbDataNascimento
            // 
            this.txbDataNascimento.Location = new System.Drawing.Point(639, 37);
            this.txbDataNascimento.Mask = "00/00/0000";
            this.txbDataNascimento.Name = "txbDataNascimento";
            this.txbDataNascimento.Size = new System.Drawing.Size(132, 20);
            this.txbDataNascimento.TabIndex = 40;
            this.txbDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // formEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbDataNascimento);
            this.Controls.Add(this.cbxNacionalidade);
            this.Controls.Add(this.cbxNaturalidade);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbContatoTelefone);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbContatoNome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAltera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.formEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbContatoNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txbCEP;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.MaskedTextBox txbContatoTelefone;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.MaskedTextBox txbMatricula;
        private System.Windows.Forms.ComboBox cbxNaturalidade;
        private System.Windows.Forms.ComboBox cbxNacionalidade;
        private System.Windows.Forms.MaskedTextBox txbDataNascimento;
    }
}