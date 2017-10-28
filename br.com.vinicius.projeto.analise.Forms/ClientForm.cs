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
    public partial class ClientForm : FormBaseControl
    {
        public ClientForm()
        {
            InitializeComponent();
            State state = new State();
            cbEstado.DataSource = state.StateList;
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
            register.Insert(client);
        }
    }
}
