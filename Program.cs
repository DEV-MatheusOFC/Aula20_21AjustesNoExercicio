using System;

namespace Aula_21___SenaiFood_Ajustes
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente matheus = new Cliente("Matheus");
            matheus.Endereco = "Av. Paulista, 524";
            Console.WriteLine( matheus.MostrarDados() );

            Restaurante bk = new Restaurante("Burguer King");
            bk.Endereco = "Av. Paulista, 524";
            Console.WriteLine( bk.MostrarDados() );

            Pedido pedido1 = new Pedido();
            pedido1.Cliente     = matheus;
            pedido1.Restaurante = bk;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Digite um item");
                pedido1.Itens[i] = Console.ReadLine();
            }

            Console.WriteLine( pedido1.EntregarPedido() ); 

        }
    }
}
