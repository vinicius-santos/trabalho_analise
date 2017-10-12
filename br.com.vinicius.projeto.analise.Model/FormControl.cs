using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace br.com.vinicius.projeto.analise.Model
{
    public  class FormBaseControl: Form
    {
        protected void KeyPressBase(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//code to enter
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyChar == 27) //scape
            {
                this.Close();
            }
        }
    }
}
