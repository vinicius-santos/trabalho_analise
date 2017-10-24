using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class Client
    {
        private int id;
        private string name;
        private string cellPhone;
        private int registration;
        private string city;
        private string state;

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

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                cellPhone = value;
            }
        }

        public int Registration
        {
            get
            {
                return registration;
            }

            set
            {
                registration = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
