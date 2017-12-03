using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IngredienteReceita
    {
        private int id;
        private int idReceita;
        private int idIngrediente;

        public int IdReceita
        {
            get
            {
                return idReceita;
            }

            set
            {
                idReceita = value;
            }
        }

        public int IdIngrediente
        {
            get
            {
                return idIngrediente;
            }

            set
            {
                idIngrediente = value;
            }
        }

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
    }
}
