using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receita
    {
        private int id;
        private string nome;
        private string comoFazer;

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string ComoFazer
        {
            get
            {
                return comoFazer;
            }

            set
            {
                comoFazer = value;
            }
        }
    }
}
