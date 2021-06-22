using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposAbstratosDeDados;

namespace pratica_2_fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fPedidos = new Fila(100);
            Fila fPagamentos = new Fila(100);
            Fila fEncomenda = new Fila(100);
            string valor = "";
            int idCliente = 1;

            Console.WriteLine("Restaurante Dona Tita.");
            Console.WriteLine("1- Para inserir clientes na fila de pedidos \n2- Para remover clientes da fila de pedidos \n3- Para remover cliente na fila de pagamento \n4- Para remover cliente da fila de encomendas \nS- Para sair");

            while (valor != "s")
            {
                switch (valor)
                {
                    case "1":
                        Console.WriteLine("Codigo do novo cliente: " + idCliente);
                        fPedidos.enfileirar(idCliente);
                        idCliente++;
                        break;
                    case "2":
                        if (fPedidos.vazia()) { Console.WriteLine("Não existem mais clientes na fila de pedidos."); break; }
                        idCliente = fPedidos.desenfileirar();
                        Console.WriteLine("Cliente " + idCliente + " saiu da fila de pedidos e entrou na fila de pagamento");
                        fPagamentos.enfileirar(idCliente);
                        break;
                    case "3":
                        if (fPagamentos.vazia()) { Console.WriteLine("Não existem mais clientes na fila de pagamentos."); break;}
                        idCliente = fPagamentos.desenfileirar();
                        Console.WriteLine("Cliente " + idCliente + " saiu da fila de pagamento e entrou na fila de encomenda.");
                        fEncomenda.enfileirar(idCliente);
                        break;
                    case "4":
                        if(fEncomenda.vazia()) { Console.WriteLine("Não existem mais clientes na fila de encomenda."); break; }
                        idCliente = fEncomenda.desenfileirar();
                        Console.WriteLine("Cliente " + idCliente + " finalizou seu pedido");
                        break;
                }
                valor = Console.ReadLine();
            }
            Console.WriteLine("Programa encerrado");
            Environment.Exit(0);
            Console.ReadKey();
        }
    }
}
