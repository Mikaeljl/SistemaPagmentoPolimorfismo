using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagmentoPolimorfismo
{
    public class PagamentoCartão : Pagamento
    {
        public override void RealizarPagamento()
        {
            Console.WriteLine("Pagamento Realizado em Cartão");
        }
    }
}
