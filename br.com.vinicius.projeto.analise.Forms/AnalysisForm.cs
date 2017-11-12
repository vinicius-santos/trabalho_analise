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
            var tipoAnalise = new TipoAnalise();
            cbTipoAnalise.DataSource = tipoAnalise.Tipos;

            var qtdAmostra = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            cbQtdAmostra.DataSource = qtdAmostra;
        }
    }
}
