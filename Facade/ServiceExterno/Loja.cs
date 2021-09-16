using System;

namespace Facade.ServiceExterno
{
    public class Loja : ILoja
    {
        public void ComprarBola()
        {
            Console.WriteLine("Comprar bola de futebol");
        }

        public void ComprarUniforme()
        {
            Console.WriteLine("Comprar uniforme do Corinthians");
        }
    }
}
