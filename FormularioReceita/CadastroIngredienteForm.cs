using Model;
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
    public partial class CadastroIngredienteForm : Form
    {
        public CadastroIngredienteForm()
        {
            InitializeComponent();
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeIngrediente.Text))
            {
                lblMessage.Text = "Valor incorreto";
                return;
            }
            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = txtNomeIngrediente.Text;
            IngredienteRegistro registro = new IngredienteRegistro();
            lblMessage.Text =  registro.Insert(ingrediente);
            CleanFields();
        }

        private void CleanFields()
        {
            foreach (Control field in this.Controls)
            {
                if (field is TextBox)
                    ((TextBox)field).Clear();
                else if (field is ComboBox)
                    ((ComboBox)field).SelectedIndex = 0;
            }
        }

        private void txtNomeIngrediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void CadastroIngredienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
