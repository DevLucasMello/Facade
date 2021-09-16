using System;
using Facade.Facade;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = LucasSportsFacade.InstanciaClient();

            Console.WriteLine("----------------COMPRAS LOJA DE ARTIGOS ESPORTIVOS------------------\n");
            facade.ItensLoja();            

            Console.WriteLine("\n----------------------COMPRAS ACADEMIA----------------------------\n");
            facade.ItensAcademia();            
        }
    }
}
