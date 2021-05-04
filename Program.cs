using System;
using System.Collections.Generic;

namespace Pedido
{
//Criar uma classe “ItemPedido” com as propriedades “descricao”, “valor_unitario” e “quantidade”.
//Criar uma classe “Pedido” com uma propriedade privada do tipo lista (List<>) de “ItemPedido” e métodos para incluir item no pedido e para totalizar o pedido – este, retorna um valor Double com o total de todos os itens da lista.
//Inclua também um construtor em “Pedido” para instanciar uma nova lista na propriedade criada.

    class ItemPedido
    {
        //PROPRIEDADES

        /*private string descricaoPrivado;
        private double valorUnitarioPrivado;
        private int quantidadePrivado;*/

        public string descricao;/*{
            get{return descricaoPrivado;}
            set{descricaoPrivado = value;}
        }*/
        public double valorUnitario;/*{
            get{return valorUnitarioPrivado;}
            set{valorUnitarioPrivado = value;}
        }*/
        public int quantidade;
        /*{
            get{return quantidadePrivado;}
            set{quantidadePrivado = value;}
        }*/

        //CONSTRUTOR
        public ItemPedido(string descricaoPrivado, double valorUnitarioPrivado, int quantidadePrivado)
        {
        descricao = descricaoPrivado;
        valorUnitario = valorUnitarioPrivado;
        quantidade = quantidadePrivado;
        }
    }

    class Pedido
    {
        //PROPRIEDADE TIPO LISTA
        private List<ItemPedido> itensPedido;
        
        public Pedido(){
            itensPedido = new List<ItemPedido>();
        }

        // MÉTODO PARA ADCIONAR ITEM NO SERVIÇO
        public void AdicionaPedido(ItemPedido item)
        {
            itensPedido.Add(item);
        }

        //MÉTODO PARA SOMAR TOTAL PEDIDO
        public double TotalPedido()
        {
            double total = 0;
            foreach(var item in itensPedido)// VAI JUNTANDO TODO O ITEM QUE ESTIVER SIDO ADCIONADO NA LISTA ITEM DE SERVIÇO(line 35 - 38)
            {
                total = total + item.valorUnitario * item.quantidade; //MULTIPLICA VALOR UNITÁRIO PELA QUANTIDADE 
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        string descricao;
        double valorUnitario;
        int quantidade;
        char finalizar = 'n';

        Pedido novoPedido = new Pedido();

        do{
            Console.WriteLine("Digite a descrição:");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite o valor unitário:");
            valorUnitario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade:");
            quantidade = Convert.ToInt16(Console.ReadLine());

            ItemPedido novoItem = new ItemPedido(descricao, valorUnitario, quantidade);
            novoPedido.AdicionaPedido(novoItem);

            Console.WriteLine("Quer continuar adicionando itens: [s/n]");
            finalizar = Convert.ToChar(Console.ReadLine());
        }
        while (finalizar == 's');

            Console.WriteLine("Total de pedidos: " + novoPedido.TotalPedido());
        }
    }
}
