using System;
namespace test.src.strategy.application.core.domain.pedido
{
    public class PedidoEletronicos : Pedido
    {
        private String? NomeSetor { get; set; }
        public PedidoEletronicos() => this.NomeSetor = "PedidoEletronicos";

    }
}

