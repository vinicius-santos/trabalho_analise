using br.com.vinicius.projeto.analise.Model;
using Newtonsoft.Json;
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
    public partial class ClientForm : FormBaseControl
    {
        private const int totalRecords = 43;
        private const int pageSize = 10;

        public ClientForm()
        {
            InitializeComponent();
            State state = new State();
            cbEstado.DataSource = state.StateList;
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id" });
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CellPhone" });
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "City" });
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name" });
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Registration" });
            dtvClient.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "State" });
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            //var records = new List<Record>();
            //for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            //    records.Add(new Record { Index = i });
            var register = new ClientRegister();
            var records = register.SelectAll();
            var clients = records.Select(x => new Client
            {
                Id = Convert.ToInt32(x.Where(y=> y.Key == "Id").FirstOrDefault().Value),
                CellPhone =(string) x.Where(y=> y.Key == "CellPhone").FirstOrDefault().Value,
                City = (string)x.Where(y=> y.Key == "City").FirstOrDefault().Value,
                Name = (string) x.Where(y=> y.Key == "Name").FirstOrDefault().Value,
                Registration = Convert.ToInt32(x.Where(y=> y.Key == "Registration").FirstOrDefault().Value),
                State = (string) (x.Where(y=> y.Key == "State").FirstOrDefault().Value),
            });
            dtvClient.DataSource = clients.ToList();
        }

      

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }


        private void ClientForm_Load(object sender, EventArgs e)
        {
        }


        private void ClientForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressBase(sender, e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var register = new ClientRegister();
            var client = new Client();
            client.CellPhone = mskTxtCel.Text;
            client.City = txtCidade.Text;
            client.Name = txtName.Text;
            if (!String.IsNullOrEmpty(txtMatricula.Text))
                client.Registration = Convert.ToInt32(txtMatricula.Text);
            client.State = cbEstado.Text;
            client.Name = txtName.Text;
            if (!ValidateUtil.validClient(client))
                lblMessage.Text = Messages.RequiredFields;
            else
                lblMessage.Text = register.Insert(client);
        }
    }
}
