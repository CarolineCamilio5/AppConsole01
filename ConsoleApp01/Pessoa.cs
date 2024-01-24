using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class Pessoa
    {
        protected long CPF;
        public String Nome;
        public string CorDoCabelo;
        public string CorDosOlhos;
        public DateTime DataNasc;
        public string NomedoFilho1;
        public string NomedoFilho2;

        // consultor
        public Pessoa(long cpf, string nome, DateTime data, string cordocabelo)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.DataNasc = data;
            this.CorDoCabelo = cordocabelo;
        }

        public float CalcularIdade()
        {
            float idade = (((DateTime.Now - DataNasc).Days) / 365);
            return idade;
        }

        public void MudaCordoCabelo(string coremRGB)
        {
            this.CorDoCabelo = coremRGB;
        }

        public void NomearFilho (string NomedoFilho1)


    }
}



        /*



        public bool VaiNumaFesta()
        {
            int idade = ((DateTime.Now - DataNasc).Days) / 365;
            if (idade >= 18)
                return true;
            else
                return false;
        }

        public void PintarCabelo()
        {
            this.CorDoCabelo = "azul";
        }



    }
}
        */