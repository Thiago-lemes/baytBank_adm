using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baytBank_adm2.Funcionario
{
    public class Diretor
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public double getBonificacao()
        {
            return Salario;
        }
    }
}
