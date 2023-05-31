using System;
namespace test.src.strategy.application.core.domain.frete
{
    public class FreteExpresso : IFreteInterface
    {
        private readonly decimal TaxaFreteExepresso = 0.1M;

        public decimal Calcula(decimal ValorPedido)
        {
            return ValorPedido * TaxaFreteExepresso;
        }
    }
}

