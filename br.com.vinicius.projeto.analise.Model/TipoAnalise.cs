using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    /// <summary>
    ///  Classe para centralizar os tipos de analises
    /// </summary>
    public class TipoAnalise
    {
        private List<string> _tipos;

        public TipoAnalise()
        {
            Tipos = new List<string>();
            Tipos.Add("B1 - Básica");
            Tipos.Add("C1 - Completa");
            Tipos.Add("E1 - Completa + S");
            Tipos.Add("E2 - Completa + B");
            Tipos.Add("E3 - Completa + P - Resina");
            Tipos.Add("E4 - Completa + S + B");
            Tipos.Add("E5 - Completa + S + P - Resina");
            Tipos.Add("E6 - Completa + P + B - Resina");
            Tipos.Add("E7 - Completa + S + B + P - Resina");
        }

        public List<string> Tipos
        {
            get
            {
                return _tipos;
            }

            set
            {
                _tipos = value;
            }
        }
    }
}
