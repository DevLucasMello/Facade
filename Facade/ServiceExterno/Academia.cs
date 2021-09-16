using System;

namespace Facade.ServiceExterno
{
    public class Academia : IAcademia
    {
        public void ComprarSuplemento()
        {
            Console.WriteLine("Comprar Whey");
        }

        public void FazerAula()
        {
            Console.WriteLine("Fazer Musculação");
        }
    }
}
