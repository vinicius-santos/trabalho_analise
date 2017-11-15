using br.com.vinicius.projeto.analise.Model;
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
    public partial class AnalysisForm : Form
    {


        public AnalysisForm()
        {
            InitializeComponent();

            bindingSource1.CurrentChanged += new System.EventHandler(cbQtdAmostra_DropDownClosed);
            //bindingSource1.DataSource = new List<Analise>();
            var register = new ClientRegister();
            var records = register.SelectAll();
            var clients = records.Select(x => new Client
            {
                Id = Convert.ToInt32(x.Where(y => y.Key == "Id").FirstOrDefault().Value),
                CellPhone = (string)x.Where(y => y.Key == "CellPhone").FirstOrDefault().Value,
                City = (string)x.Where(y => y.Key == "City").FirstOrDefault().Value,
                Name = (string)x.Where(y => y.Key == "Name").FirstOrDefault().Value,
                Registration = Convert.ToInt32(x.Where(y => y.Key == "Registration").FirstOrDefault().Value),
                State = (string)(x.Where(y => y.Key == "State").FirstOrDefault().Value),
            });
            cbCliente.DataSource = clients.ToList();
            cbSolicitante.DataSource = clients.ToList();
            cbSolicitante.SelectedIndex = -1;
            cbCliente.SelectedIndex = -1;

            var tipoAnalise = new TipoAnalise();
            cbTipoAnalise.DataSource = tipoAnalise.Tipos;
            cbTipoAnalise.SelectedIndex = -1;

            var qtdAmostra = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,18,19,20 // total de vinte amostras pode ser alterado.
            };
            cbQtdAmostra.DataSource = qtdAmostra;
            cbQtdAmostra.SelectedIndex = -1;


        }

        //private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        //{
        //    dtvClient.DataSource = RefreshGrid();
        //    dtvClient.Refresh();
        //}

        private void cbSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {

        }

        private void cbCliente_DropDownClosed(object sender, EventArgs e)
        {
            var client = (Client)cbCliente.SelectedItem;
            lblCidadeShow.Text = client.City;
            lblMatriculaShow.Text = Convert.ToString(client.Registration);
            lblTelefoneShow.Text = client.CellPhone;
        }

        private void cbQtdAmostra_DropDownClosed(object sender, EventArgs e)
        {
            var qtd = Convert.ToInt32(cbQtdAmostra.SelectedValue);
            var list = new List<Analise>();
            for (int i = 0; i < qtd; i++)
            {
                Analise analise = new Analise();
                list.Add(analise);
            }
            dataGridView1.DataSource = list.ToList();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["tipoAnalise"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["idCliente"].Visible = false;
            dataGridView1.Columns["idSolicitante"].Visible = false;
            dataGridView1.Columns["geoReferencia"].HeaderText = "GeoReferência";
            dataGridView1.Columns["complemento"].HeaderText = "Complemento";
            dataGridView1.Refresh();
        }
    }
}
