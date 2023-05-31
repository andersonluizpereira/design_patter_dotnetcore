using System;
namespace test.src.strategy.application.core.domain.frete
{
    public class FreteComum : IFreteInterface
    {
        private readonly decimal TaxaFreteComun = 0.05M;

        public decimal Calcula(decimal ValorPedido)
        {
            return ValorPedido * TaxaFreteComun;
        }
    }
}

