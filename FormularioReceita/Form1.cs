using br.com.vinicius.projeto.analise.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioReceita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarIngrediente_Click(object sender, EventArgs e)
        {
            CadastroIngredienteForm form = new CadastroIngredienteForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnCadastroReceita_Click(object sender, EventArgs e)
        {
            CadastroReceitaForm form = new CadastroReceitaForm();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
