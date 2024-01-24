using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class Funcionario : Pessoa, InterfaceFuncionario
    {
        protected float salario;  // pode atualizar, mas não ver
        public DateTime dataEntrada;
        public List <string> ListFunc;


        public Funcionario (long cpf, string nome, DateTime data, string cordocabelo): base (cpf, nome, data, cordocabelo)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.DataNasc = data;
            this.CorDoCabelo = cordocabelo;

        }

        public void AtualizarSalario (float salario)
        {
            this.salario = salario;

        }

        public void Contrata(float salario, DateTime dataent)
        {
            this.salario= salario;
            this.dataEntrada = dataent;
        }

        public void Cadastra(Pessoa pes, float salario, DateTime dataentdataEntrada)
        {
            throw new NotImplementedException();
        }

        public void Altera(int Id, Pessoa pes, float salario)
        {
            throw new NotImplementedException();
        }

        public void Exclusao()
        {
            throw new NotImplementedException();
        }
    }
}
