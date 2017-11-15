using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class Analise
    {

        private int id;
        private string tipoAnalise;
        private string geoReferencia;
        private string complemento;
        private string status;
        private int idCliente;
        private int idSolicitante;

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

        public string TipoAnalise
        {
            get
            {
                return tipoAnalise;
            }

            set
            {
                tipoAnalise = value;
            }
        }

        public string GeoReferencia
        {
            get
            {
                return geoReferencia;
            }

            set
            {
                geoReferencia = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
