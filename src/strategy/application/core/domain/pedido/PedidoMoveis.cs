using System;
namespace test.src.strategy.application.core.domain.pedido
{
    public class PedidoMoveis : Pedido
    {
        private String? NomeSetor { get; set; }
        public PedidoMoveis() => this.NomeSetor = "PedidoEletronicos";
    }
}

