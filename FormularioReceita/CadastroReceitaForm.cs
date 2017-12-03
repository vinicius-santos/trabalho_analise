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

namespace br.com.vinicius.projeto.analise.Forms
{
    public partial class CadastroReceitaForm : Form
    {
        private List<Ingrediente> _ingredients;
        public CadastroReceitaForm()
        {
            InitializeComponent();
            IngredienteRegistro register = new IngredienteRegistro();
            var records = register.SelectAll();
            var ingredientes = records.Select(x => new Ingrediente
            {
                Id = Convert.ToInt32(x.Where(y => y.Key == "Id").FirstOrDefault().Value),
                Nome = (string)x.Where(y => y.Key == "Nome").FirstOrDefault().Value,
            });
            cbIngredientes.DataSource = ingredientes.ToList();

            _ingredients = new List<Ingrediente>();
        }

        private void cbIngredientes_DropDownClosed(object sender, EventArgs e)
        {
            var item = (Ingrediente)cbIngredientes.SelectedItem;
            _ingredients.Add(item);
            txtMostraIngredientes.Text = txtMostraIngredientes.Text + item.Nome + Environment.NewLine;
            txtMostraIngredientes.Refresh();
        }

        private void cbIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            var msg = "";
            //salvar ingredientes e vincular id após isso salvar receita
            Receita receita = new Receita();
            receita.Nome = txtNomeReceita.Text;
            receita.ComoFazer = txtComoFazer.Text;
            ReceitaRegistro registro = new ReceitaRegistro();
            var id = registro.Insert(receita);
            foreach (var item in _ingredients)
            {
                if (id != -1)
                {
                    IngredienteReceita ingredienteReceita = new IngredienteReceita();
                    ingredienteReceita.IdReceita = id;
                    ingredienteReceita.IdIngrediente = item.Id;
                    msg = registro.InsertIngredientsReceita(ingredienteReceita);
                }
                else
                {
                    lblMessage.Text = msg;
                    return;
                }
            }
            lblMessage.Text = msg;
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
    }
}
