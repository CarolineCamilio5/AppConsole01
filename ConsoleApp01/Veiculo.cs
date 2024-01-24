using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class Veiculo
    {
        public string Nome;
        public string Cor;
        public int Ano;
        public float Preco;
        public float Velocidade;

        public Veiculo (string nome, string cor, int ano, float preco, float veloc)
        {
            this.Nome = nome;
            this.Cor = cor;
            this.Ano = ano;
            this.Preco = preco;
            this.Velocidade = veloc;

        }


        public void AtualizarVelocidade(float veloc)
        {
            this.Velocidade += veloc;

        }

        public void Parar ()
        {
            this.Velocidade = 0;
        }

        public void AnodoVeiculo ()
        {
            if (this.Ano < DateTime.Now.Year)
            {
                this.Preco = (float)(this.Preco * 0.7);
            }
        }



    }
}
