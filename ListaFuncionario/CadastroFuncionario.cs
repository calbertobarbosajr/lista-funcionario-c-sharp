using ListaFuncionario.Data;
using ListaFuncionario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ListaFuncionario
{
    public partial class CadastroFuncionario : Form
    {

        private TelaPrincipal telaPrincipal;
        private Funcionario func;
        public CadastroFuncionario(TelaPrincipal tela)
        {
            telaPrincipal = tela;
            InitializeComponent();
        }

        public CadastroFuncionario(TelaPrincipal tela, int Id)
        {
            telaPrincipal = tela;
            InitializeComponent();

            func = FuncionarioDataAccess.PegarFuncionario(Id);
            CarregandoDadosFuncionarios(func);
        }

        private void CarregandoDadosFuncionarios(Funcionario funcionario)
        {
            textBoxNome.Text = funcionario.Nome.Trim();
            textBoxEmail.Text = funcionario.Email.Trim();
            textBoxSalario.Text = funcionario.Salario.ToString();

            if (funcionario.Sexo == "M") { radioButtonMasculino.Checked = true; } else { radioButtonFeminino.Checked = true; };
            if (funcionario.TipoContrato == "CLT") { radioButtonClt.Checked = true; } else if (funcionario.TipoContrato == "PJ") { radioButtonPj.Checked = true; } else { radioButtonAutonomo.Checked = true; };
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario;
            if (func != null)
            {
                //Atualizacao
                funcionario = func;
                funcionario.DataAtualizacao = DateTime.Now;
            }
            else
            {
                //Cadastro novo
                funcionario = new Funcionario();
                funcionario.DataCadastro = DateTime.Now;
            }


            //Mover os dados para a Classe Funcionario
            //Funcionario funcionario = new Funcionario();
            funcionario.Nome = textBoxNome.Text.Trim();
            funcionario.Email = textBoxEmail.Text.Trim();
            funcionario.Salario = decimal.Parse(textBoxSalario.Text);
            funcionario.Sexo = (radioButtonMasculino.Checked) ? "M" : "F";
            funcionario.TipoContrato = (radioButtonClt.Checked) ? "CLT" : (radioButtonPj.Checked) ? "PJ" : "AUT";


            //Validar os dados
            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(funcionario);
            bool validado = Validator.TryValidateObject(funcionario, contexto, listErros, true);
            if (validado)
            {
                //Salvar os dados
                //Fechar e Atualizar a TelaPrincipal
                bool resultado;
                if (func != null)
                {
                    //Atualizar;
                    resultado = FuncionarioDataAccess.AtualizarFuncionario(funcionario);
                }
                else
                {
                    resultado = FuncionarioDataAccess.SalvarFuncionario(funcionario);
                }


                if (resultado)
                {
                    //Sucesso
                    telaPrincipal.ObterTodosFuncionarios();
                    this.Close();
                }
                else
                {
                    //Erro
                    labelErros.Text = "Erro na inserção - Banco!";
                }
            }
            else
            {
                //Validação Erro.
                // A lista de erro será guardado na variável sb
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult erro in listErros)
                {
                    // Cada erro gera uma mensagem que é o erro.ErrorMessage + "\n"
                    sb.Append(erro.ErrorMessage + "\n");
                }
                // Os erros serão exibidos na label 
                labelErros.Text = sb.ToString();
            }
        }
    }
}
