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
    public partial class PrincipalScreen : FormBaseControl
    {
        public PrincipalScreen()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Owner = this;
            clientForm.ShowDialog();
        }

        private void PrincipalScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressBase(sender, e);
        }

        private void tipoDeAnáliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalysisForm form = new AnalysisForm();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
