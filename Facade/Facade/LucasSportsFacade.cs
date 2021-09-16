using Facade.ServiceExterno;

namespace Facade.Facade
{
    public class LucasSportsFacade : ILucasSportsFacade
    {
        private ILoja _loja;
        private IAcademia _academia;

        public LucasSportsFacade()
        {
            InstanciarFacade();
        }

        public void ItensLoja()
        {
            _loja.ComprarBola();
            _loja.ComprarUniforme();
        }

        public void ItensAcademia()
        {
            _academia.ComprarSuplemento();
            _academia.FazerAula();
        }
        
        // Resolver com DI
        private void InstanciarFacade()
        {
            _loja = new Loja();
            _academia = new Academia();
        }

        public static LucasSportsFacade InstanciaClient()
        {
            return new LucasSportsFacade();
        }
    }
}
