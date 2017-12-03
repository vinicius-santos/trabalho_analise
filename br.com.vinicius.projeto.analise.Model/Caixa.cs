using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class Caixa
    {
        private int id;
        private int idAmostra;

        private bool analisada;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdAmostra
        {
            get
            {
                return idAmostra;
            }

            set
            {
                idAmostra = value;
            }
        }

        public bool Analisada
        {
            get
            {
                return analisada;
            }

            set
            {
                analisada = value;
            }
        }
    }
}
