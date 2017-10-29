using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public static class ValidateUtil
    {
        public static bool validClient(Client client)
        {
            if (String.IsNullOrEmpty(client.Name)) return false;
            if (client.Registration <= 0) return false;
            if (String.IsNullOrEmpty(client.City)) return false;
            if (String.IsNullOrEmpty(client.State)) return false;
            return true;
        }
        public static bool validFieldInt(int value)
        {
            if (value <= 0) return false;
            return true;
        }
    }
}
