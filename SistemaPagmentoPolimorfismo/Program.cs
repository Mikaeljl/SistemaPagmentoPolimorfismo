using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagmentoPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pagamento> pagamentos = new List<Pagamento>
            {
                new PagamentoCartão {},
                new PagamentoDinheiro { },

            };

            foreach (var pagamento in pagamentos)
            {
                pagamento.RealizarPagamento(); // Polimorfismo em ação
            }

            Console.ReadLine();
        }
    }
}
