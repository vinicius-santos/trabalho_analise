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
using static System.Windows.Forms.ListBox;

namespace br.com.vinicius.projeto.analise.Forms
{
    public partial class BoxForm : Form

    {
        private IEnumerable<Amostra> _analise;
        public BoxForm()
        {
            var register = new AmostraRegister();
            var records = register.SelectAll();

            _analise = records.Select(x => new Amostra
            {
                Id = Convert.ToInt32(x.Where(y => y.Key == "Id").FirstOrDefault().Value),
                Complemento = (string)x.Where(y => y.Key == "Complemento").FirstOrDefault().Value,
                GeoReferencia = (string)x.Where(y => y.Key == "GeoReferencia").FirstOrDefault().Value,
                IdCliente = (int)x.Where(y => y.Key == "IdCliente").FirstOrDefault().Value,
                IdSolicitante = Convert.ToInt32(x.Where(y => y.Key == "IdSolicitante").FirstOrDefault().Value),
                Status = (string)(x.Where(y => y.Key == "Status").FirstOrDefault().Value),
                TipoAnalise = (string)(x.Where(y => y.Key == "TipoAnalise").FirstOrDefault().Value),
            });


            InitializeComponent();
            foreach (var item in _analise)
            {
                lbBoxLoad.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var itens = lbBoxLoad.SelectedItems;
            if (itens.Count == 0) return;
            foreach (var item in itens)
            {
                if (item != null)
                {
                    if (!lbLoadAll.Items.Contains(item))
                    {
                        if (lbLoadAll.Items.Count < 12)
                            lbLoadAll.Items.Add(item);
                    }
                }
            }

            foreach (var item in lbLoadAll.Items)
            {
                if (itens.Contains(item))
                {
                    lbBoxLoad.Items.Remove(item);
                }
            }

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            var items = lbLoadAll.SelectedItems;
            if (items.Count == 0) return;
            foreach (var item in items)
            {
                lbBoxLoad.Items.Add(item);
            }

            foreach (var item in lbBoxLoad.Items)
            {
                lbLoadAll.Items.Remove(item);
            }
        }

        private void lbLoadAll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCaixa_Click(object sender, EventArgs e)
        {
            var items = lbLoadAll.Items;
            if (items.Count == 0) return;
            var register = new CaixaRegister();
            var amostraRegister = new AmostraRegister();
            foreach (var item in items)
            {
                Caixa caixa = new Caixa();
                Amostra amostra = (Amostra)item;
                amostra.Status = "Em analise";
                caixa.IdAmostra = amostra.Id;
                register.Insert(caixa);
                amostraRegister.Edit(amostra);
            }
        }
    }
}
