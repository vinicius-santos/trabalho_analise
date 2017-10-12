using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class Requester
    {
        private int id;
        private string name;
        private int matricula;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }
    }
}
