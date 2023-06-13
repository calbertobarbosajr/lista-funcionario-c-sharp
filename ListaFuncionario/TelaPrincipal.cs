using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFuncionario
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            ObterTodosFuncionarios();
        }

        public void ObterTodosFuncionarios()
        {
            dataGridViewLista.DataSource = Data.FuncionarioDataAccess.ObterTodosFuncionarios();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new CadastroFuncionario(this).Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewLista.SelectedRows[0].Cells[0].Value;
            new CadastroFuncionario(this, id).Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewLista.SelectedRows[0].Cells[0].Value;
            Data.FuncionarioDataAccess.ExcluirFuncionario(id);
            ObterTodosFuncionarios();

        }
    }
}
