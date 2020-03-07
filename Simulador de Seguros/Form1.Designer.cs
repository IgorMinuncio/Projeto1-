namespace Simulador_de_Seguros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBarretos = new System.Windows.Forms.RadioButton();
            this.buttonFranca = new System.Windows.Forms.RadioButton();
            this.buttonPetropolis = new System.Windows.Forms.RadioButton();
            this.buttonTresRios = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDesastre = new System.Windows.Forms.CheckBox();
            this.checkBoxRoubo = new System.Windows.Forms.CheckBox();
            this.SP = new System.Windows.Forms.RadioButton();
            this.RJ = new System.Windows.Forms.RadioButton();
            this.numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numeroCasa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonSimAlarme = new System.Windows.Forms.RadioButton();
            this.radioButtonNaoAlarme = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.MaskedTextBox();
            this.rightEmail = new System.Windows.Forms.PictureBox();
            this.wrongEmail = new System.Windows.Forms.PictureBox();
            this.logradouro = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.valorImovel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBarretos
            // 
            this.buttonBarretos.AutoSize = true;
            this.buttonBarretos.Location = new System.Drawing.Point(17, 38);
            this.buttonBarretos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBarretos.Name = "buttonBarretos";
            this.buttonBarretos.Size = new System.Drawing.Size(83, 21);
            this.buttonBarretos.TabIndex = 1;
            this.buttonBarretos.TabStop = true;
            this.buttonBarretos.Text = "Barretos";
            this.buttonBarretos.UseVisualStyleBackColor = true;
            this.buttonBarretos.Visible = false;
            this.buttonBarretos.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // buttonFranca
            // 
            this.buttonFranca.AutoSize = true;
            this.buttonFranca.Location = new System.Drawing.Point(17, 92);
            this.buttonFranca.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFranca.Name = "buttonFranca";
            this.buttonFranca.Size = new System.Drawing.Size(73, 21);
            this.buttonFranca.TabIndex = 2;
            this.buttonFranca.TabStop = true;
            this.buttonFranca.Text = "Franca";
            this.buttonFranca.UseVisualStyleBackColor = true;
            this.buttonFranca.Visible = false;
            this.buttonFranca.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // buttonPetropolis
            // 
            this.buttonPetropolis.AutoSize = true;
            this.buttonPetropolis.Location = new System.Drawing.Point(17, 38);
            this.buttonPetropolis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPetropolis.Name = "buttonPetropolis";
            this.buttonPetropolis.Size = new System.Drawing.Size(92, 21);
            this.buttonPetropolis.TabIndex = 3;
            this.buttonPetropolis.TabStop = true;
            this.buttonPetropolis.Text = "Petropolis";
            this.buttonPetropolis.UseVisualStyleBackColor = true;
            this.buttonPetropolis.Visible = false;
            this.buttonPetropolis.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // buttonTresRios
            // 
            this.buttonTresRios.AutoSize = true;
            this.buttonTresRios.Location = new System.Drawing.Point(17, 94);
            this.buttonTresRios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTresRios.Name = "buttonTresRios";
            this.buttonTresRios.Size = new System.Drawing.Size(90, 21);
            this.buttonTresRios.TabIndex = 4;
            this.buttonTresRios.TabStop = true;
            this.buttonTresRios.Text = "Três Rios";
            this.buttonTresRios.UseVisualStyleBackColor = true;
            this.buttonTresRios.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor do imovel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDesastre);
            this.groupBox1.Controls.Add(this.checkBoxRoubo);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(511, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguros Adicionais";
            // 
            // checkBoxDesastre
            // 
            this.checkBoxDesastre.AutoSize = true;
            this.checkBoxDesastre.Location = new System.Drawing.Point(41, 70);
            this.checkBoxDesastre.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDesastre.Name = "checkBoxDesastre";
            this.checkBoxDesastre.Size = new System.Drawing.Size(151, 21);
            this.checkBoxDesastre.TabIndex = 1;
            this.checkBoxDesastre.Text = "Desastres Naturais";
            this.checkBoxDesastre.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoubo
            // 
            this.checkBoxRoubo.AutoSize = true;
            this.checkBoxRoubo.Location = new System.Drawing.Point(41, 42);
            this.checkBoxRoubo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRoubo.Name = "checkBoxRoubo";
            this.checkBoxRoubo.Size = new System.Drawing.Size(79, 21);
            this.checkBoxRoubo.TabIndex = 0;
            this.checkBoxRoubo.Text = "Roubos";
            this.checkBoxRoubo.UseVisualStyleBackColor = true;
            this.checkBoxRoubo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SP
            // 
            this.SP.AutoSize = true;
            this.SP.Location = new System.Drawing.Point(16, 38);
            this.SP.Margin = new System.Windows.Forms.Padding(4);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(94, 21);
            this.SP.TabIndex = 15;
            this.SP.TabStop = true;
            this.SP.Text = "São Paulo";
            this.SP.UseVisualStyleBackColor = true;
            this.SP.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // RJ
            // 
            this.RJ.AutoSize = true;
            this.RJ.Location = new System.Drawing.Point(16, 92);
            this.RJ.Margin = new System.Windows.Forms.Padding(4);
            this.RJ.Name = "RJ";
            this.RJ.Size = new System.Drawing.Size(121, 21);
            this.RJ.TabIndex = 16;
            this.RJ.TabStop = true;
            this.RJ.Text = "Rio de Janeiro";
            this.RJ.UseVisualStyleBackColor = true;
            this.RJ.CheckedChanged += new System.EventHandler(this.RJ_CheckedChanged);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(129, 207);
            this.numero.Margin = new System.Windows.Forms.Padding(4);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(75, 22);
            this.numero.TabIndex = 19;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Logradouro";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numeroCasa
            // 
            this.numeroCasa.AutoSize = true;
            this.numeroCasa.Location = new System.Drawing.Point(63, 210);
            this.numeroCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeroCasa.Name = "numeroCasa";
            this.numeroCasa.Size = new System.Drawing.Size(58, 17);
            this.numeroCasa.TabIndex = 21;
            this.numeroCasa.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Valor dos bens no Imóvel";
            this.label9.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 316);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            // 
            // radioButtonSimAlarme
            // 
            this.radioButtonSimAlarme.AutoSize = true;
            this.radioButtonSimAlarme.Location = new System.Drawing.Point(8, 23);
            this.radioButtonSimAlarme.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSimAlarme.Name = "radioButtonSimAlarme";
            this.radioButtonSimAlarme.Size = new System.Drawing.Size(52, 21);
            this.radioButtonSimAlarme.TabIndex = 26;
            this.radioButtonSimAlarme.TabStop = true;
            this.radioButtonSimAlarme.Text = "Sim";
            this.radioButtonSimAlarme.UseVisualStyleBackColor = true;
            this.radioButtonSimAlarme.Visible = false;
            // 
            // radioButtonNaoAlarme
            // 
            this.radioButtonNaoAlarme.AutoSize = true;
            this.radioButtonNaoAlarme.Location = new System.Drawing.Point(72, 23);
            this.radioButtonNaoAlarme.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNaoAlarme.Name = "radioButtonNaoAlarme";
            this.radioButtonNaoAlarme.Size = new System.Drawing.Size(55, 21);
            this.radioButtonNaoAlarme.TabIndex = 27;
            this.radioButtonNaoAlarme.TabStop = true;
            this.radioButtonNaoAlarme.Text = "Não";
            this.radioButtonNaoAlarme.UseVisualStyleBackColor = true;
            this.radioButtonNaoAlarme.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNaoAlarme);
            this.groupBox2.Controls.Add(this.radioButtonSimAlarme);
            this.groupBox2.Location = new System.Drawing.Point(511, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(189, 62);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imóvel possui alarme?";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SP);
            this.groupBox3.Controls.Add(this.RJ);
            this.groupBox3.Location = new System.Drawing.Point(44, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(185, 144);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPetropolis);
            this.groupBox4.Controls.Add(this.buttonBarretos);
            this.groupBox4.Controls.Add(this.buttonFranca);
            this.groupBox4.Controls.Add(this.buttonTresRios);
            this.groupBox4.Location = new System.Drawing.Point(263, 262);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(181, 144);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cidade";
            this.groupBox4.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 50);
            this.button2.TabIndex = 32;
            this.button2.Text = "Calcular Valor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(129, 79);
            this.telefone.Margin = new System.Windows.Forms.Padding(4);
            this.telefone.Mask = "(00)00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(240, 22);
            this.telefone.TabIndex = 34;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Telefone_MaskInputRejected);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(129, 111);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(240, 22);
            this.email.TabIndex = 35;
            this.email.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Email_MaskInputRejected);
            this.email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // rightEmail
            // 
            this.rightEmail.Image = ((System.Drawing.Image)(resources.GetObject("rightEmail.Image")));
            this.rightEmail.Location = new System.Drawing.Point(379, 111);
            this.rightEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rightEmail.Name = "rightEmail";
            this.rightEmail.Size = new System.Drawing.Size(29, 25);
            this.rightEmail.TabIndex = 36;
            this.rightEmail.TabStop = false;
            this.rightEmail.Visible = false;
            this.rightEmail.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // wrongEmail
            // 
            this.wrongEmail.Image = ((System.Drawing.Image)(resources.GetObject("wrongEmail.Image")));
            this.wrongEmail.Location = new System.Drawing.Point(379, 111);
            this.wrongEmail.Margin = new System.Windows.Forms.Padding(4);
            this.wrongEmail.Name = "wrongEmail";
            this.wrongEmail.Size = new System.Drawing.Size(29, 25);
            this.wrongEmail.TabIndex = 37;
            this.wrongEmail.TabStop = false;
            this.wrongEmail.Visible = false;
            this.wrongEmail.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // logradouro
            // 
            this.logradouro.Location = new System.Drawing.Point(129, 175);
            this.logradouro.Margin = new System.Windows.Forms.Padding(4);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(240, 22);
            this.logradouro.TabIndex = 18;
            this.logradouro.TextChanged += new System.EventHandler(this.logradouro_TextChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(131, 50);
            this.nome.Margin = new System.Windows.Forms.Padding(4);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(240, 22);
            this.nome.TabIndex = 39;
            this.nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // valorImovel
            // 
            this.valorImovel.Location = new System.Drawing.Point(131, 143);
            this.valorImovel.Name = "valorImovel";
            this.valorImovel.Size = new System.Drawing.Size(239, 22);
            this.valorImovel.TabIndex = 40;
            this.valorImovel.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.valorImovel);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.wrongEmail);
            this.Controls.Add(this.rightEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numeroCasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.logradouro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(869, 559);
            this.MinimumSize = new System.Drawing.Size(869, 559);
            this.Name = "Form1";
            this.Text = "Simulador de Seguros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton buttonBarretos;
        private System.Windows.Forms.RadioButton buttonFranca;
        private System.Windows.Forms.RadioButton buttonPetropolis;
        private System.Windows.Forms.RadioButton buttonTresRios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDesastre;
        private System.Windows.Forms.CheckBox checkBoxRoubo;
        private System.Windows.Forms.RadioButton SP;
        private System.Windows.Forms.RadioButton RJ;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numeroCasa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonSimAlarme;
        private System.Windows.Forms.RadioButton radioButtonNaoAlarme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox email;
        private System.Windows.Forms.PictureBox rightEmail;
        private System.Windows.Forms.PictureBox wrongEmail;
        private System.Windows.Forms.TextBox logradouro;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox valorImovel;
    }
}

