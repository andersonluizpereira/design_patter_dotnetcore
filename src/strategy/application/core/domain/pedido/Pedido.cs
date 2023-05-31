using System;
using test.src.strategy.application.core.domain.frete;

namespace test.src.strategy.application.core.domain.pedido
{
    public abstract class Pedido
    {
        public decimal ValorPedido { get; set; }
        public IFreteInterface? Frete { get; set; }

        public decimal CalcularFrete()
        {
            return Frete.Calcula(ValorPedido);
        }
    }
}

