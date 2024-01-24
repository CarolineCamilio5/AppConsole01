using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    internal class Metro: Veiculo
    {
        protected float preco;  

        public Metro (string nome, string cor, int ano, float preco, float veloc) : base(nome, cor, ano, preco, veloc)
        {
            this.Nome = nome;
            this.Cor = cor;
            this.Ano = ano;
            this.Preco = preco;
            this.Velocidade = veloc;

        }
        public void AtualizarPreco(float salario)
        {
            this.Preco = preco;
        }

        public void MudancadeVelocidade(float veloc)
        {
            this.Velocidade = veloc;
        }
    }
}
