using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public interface InterfaceFuncionario
    {
        public void Cadastra(Pessoa pes, float salario, DateTime dataentdataEntrada);
        public void Altera(int Id, Pessoa pes, float salario);
        public void Exclusao ()
    }
}
