using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class State
    {
        private List<string> stateList;


        public State()
        {
            StateList = new List<string>();
            StateList.Add("AC");
            StateList.Add("AL");
            StateList.Add("AP");
            StateList.Add("AM");
            StateList.Add("BA");
            StateList.Add("CE");
            StateList.Add("DF");
            StateList.Add("ES");
            StateList.Add("GO");
            StateList.Add("MA");
            StateList.Add("MT");
            StateList.Add("MS");
            StateList.Add("MG");
            StateList.Add("PA");
            StateList.Add("PB");
            StateList.Add("PR");
            StateList.Add("PE");
            StateList.Add("PI");
            StateList.Add("RJ");
            StateList.Add("RN");
            StateList.Add("RS");
            StateList.Add("RO");
            StateList.Add("RR");
            StateList.Add("SC");
            StateList.Add("SP");
            StateList.Add("SE");
            StateList.Add("TO");
        }

        public List<string> StateList
        {
            get
            {
                return stateList;
            }

            set
            {
                stateList = value;
            }
        }
    }
}
