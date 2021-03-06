﻿using br.com.vinicius.projeto.analise.Model;
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
        public ClientForm()
        {
            InitializeComponent();
            State state = new State();
            cbEstado.DataSource = state.StateList;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = RefreshGrid();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            dtvClient.DataSource = RefreshGrid();
            dtvClient.Refresh();
        }

        private List<Client> RefreshGrid()
        {
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

            return clients.ToList();

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
            if (!ValidateUtil.ValidClient(client))
                lblMessage.Text = Messages.RequiredFields;
            else
            {
                lblMessage.Text = register.Insert(client);
                dtvClient.DataSource = RefreshGrid();
                CleanFields();
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var register = new ClientRegister();
            if (dtvClient.CurrentRow == null)
            {
                lblMessage.Text = Messages.Empty;
                return;
            }
            var client = (Client)dtvClient.CurrentRow.DataBoundItem;
            if (0 >= (client.Registration))
                client.Registration = Convert.ToInt32(txtMatricula.Text);
            else if (!ValidateUtil.ValidClient(client))
                lblMessage.Text = Messages.RequiredFields;
            else if (!ValidateUtil.ValidFieldState(client.State.ToUpper()))
                lblMessage.Text = Messages.StateError;
            else
            {
                lblMessage.Text = register.Edit(client);
                dtvClient.DataSource = RefreshGrid();
                CleanFields();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var register = new ClientRegister();
            if (dtvClient.CurrentRow == null)
            {
                lblMessage.Text = Messages.Empty;
                return;
            }
            var client = (Client)dtvClient.CurrentRow.DataBoundItem;
            lblMessage.Text = register.Delete(client);
            dtvClient.DataSource = RefreshGrid();
            CleanFields();
        }
    }
}
