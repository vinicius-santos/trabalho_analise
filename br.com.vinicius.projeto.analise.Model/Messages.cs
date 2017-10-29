using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{

   
    /// <summary>
    /// Clase utilizada para retornar mensagens com o cliente, 
    /// serve para centralizar e facilitar a manutenção de msg
    /// </summary>
    public static class Messages
    {
        public static string ErrorDB(Exception ex)
        {
            return String.Format("Houve um erro na operação com o banco de dados" +
                "Detalhes: {0}", ex.InnerException);
        }

        public static string SuccesssDB = "Operação realizada com sucesso!";
        public static string RequiredFields = "Por favor, preencha todos os campos obrigatórios marcados com '*'";


    }
}
