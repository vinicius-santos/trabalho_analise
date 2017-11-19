using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public static class ValidateUtil
    {
        public static bool ValidClient(Client client)
        {
            if (String.IsNullOrEmpty(client.Name)) return false;
            if (client.Registration <= 0) return false;
            if (String.IsNullOrEmpty(client.City)) return false;
            if (String.IsNullOrEmpty(client.State)) return false;
            return true;
        }
        public static bool ValidAmostra(Amostra amostra)
        {
            if (String.IsNullOrEmpty(amostra.Complemento)) return false;
            if (String.IsNullOrEmpty(amostra.GeoReferencia)) return false;
            if (amostra.IdCliente <= 0) return false;
            if (amostra.IdSolicitante <= 0) return false;
            if (String.IsNullOrEmpty(amostra.Status)) return false;
            if (String.IsNullOrEmpty(amostra.TipoAnalise)) return false;
            return true;
        }
        public static bool ValidFieldInt(int value)
        {
            if (value <= 0) return false;
            return true;
        }

        public static bool ValidFieldState(string value)
        {
            var states = new State();
            var exist = states.StateList.FirstOrDefault(x=>x.Equals(value));
            if (exist == null) return false;
            return true;
        }
    }
}
