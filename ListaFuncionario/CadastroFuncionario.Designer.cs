namespace ListaFuncionario
{
    partial class CadastroFuncionario
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonClt = new System.Windows.Forms.RadioButton();
            this.radioButtonPj = new System.Windows.Forms.RadioButton();
            this.radioButtonAutonomo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.labelErros = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 67);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(12, 125);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 2;
            this.labelSalario.Text = "Salário";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 26);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(450, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(517, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(126, 23);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(15, 23);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonClt
            // 
            this.radioButtonClt.AutoSize = true;
            this.radioButtonClt.Location = new System.Drawing.Point(9, 19);
            this.radioButtonClt.Name = "radioButtonClt";
            this.radioButtonClt.Size = new System.Drawing.Size(45, 17);
            this.radioButtonClt.TabIndex = 5;
            this.radioButtonClt.TabStop = true;
            this.radioButtonClt.Text = "CLT";
            this.radioButtonClt.UseVisualStyleBackColor = true;
            // 
            // radioButtonPj
            // 
            this.radioButtonPj.AutoSize = true;
            this.radioButtonPj.Location = new System.Drawing.Point(70, 19);
            this.radioButtonPj.Name = "radioButtonPj";
            this.radioButtonPj.Size = new System.Drawing.Size(37, 17);
            this.radioButtonPj.TabIndex = 6;
            this.radioButtonPj.TabStop = true;
            this.radioButtonPj.Text = "PJ";
            this.radioButtonPj.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutonomo
            // 
            this.radioButtonAutonomo.AutoSize = true;
            this.radioButtonAutonomo.Location = new System.Drawing.Point(124, 19);
            this.radioButtonAutonomo.Name = "radioButtonAutonomo";
            this.radioButtonAutonomo.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAutonomo.TabIndex = 7;
            this.radioButtonAutonomo.TabStop = true;
            this.radioButtonAutonomo.Text = "Autônomo";
            this.radioButtonAutonomo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAutonomo);
            this.groupBox2.Controls.Add(this.radioButtonClt);
            this.groupBox2.Controls.Add(this.radioButtonPj);
            this.groupBox2.Location = new System.Drawing.Point(519, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Contrato";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 83);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(450, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(12, 141);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalario.TabIndex = 10;
            // 
            // labelErros
            // 
            this.labelErros.AutoSize = true;
            this.labelErros.ForeColor = System.Drawing.Color.Firebrick;
            this.labelErros.Location = new System.Drawing.Point(12, 173);
            this.labelErros.Name = "labelErros";
            this.labelErros.Size = new System.Drawing.Size(35, 13);
            this.labelErros.TabIndex = 11;
            this.labelErros.Text = "label1";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 290);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 50);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 352);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelErros);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonClt;
        private System.Windows.Forms.RadioButton radioButtonPj;
        private System.Windows.Forms.RadioButton radioButtonAutonomo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label labelErros;
        private System.Windows.Forms.Button buttonSalvar;
    }
}