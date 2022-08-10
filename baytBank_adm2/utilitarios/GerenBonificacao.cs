using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baytBank_adm2.Funcionario;

namespace baytBank_adm2.utilitarios
{
    public class GerenBonificacao
    {
        private double totalBonificacao { get; set; }
        
        public void Registrar(Funcionario funcionario)
        {

        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }

    }
}
