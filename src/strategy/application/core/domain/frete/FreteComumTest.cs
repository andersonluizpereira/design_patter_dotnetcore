    using System;
    namespace test.src.strategy.application.core.domain.frete
    {
        public class FreteComumTest
        {
            private readonly FreteComum freteComum;

            public FreteComumTest()
            {
                freteComum = new FreteComum();
            }

            [TestCase(5, 100,
                TestName = "Calcular Frete com a taxa de 5 valor do frete de 100.")]
            [TestCase(0, 0,
                TestName = "Calcular Frete com a taxa de 0 valor do frete de 0.")]
        [TestCase(-0.05, -1,
                TestName = "Calcular Frete com a taxa de -0.05 valor do frete de -100.")]
        public void TestarCalculoFreteComun(
                decimal TaxaFreteComum,
                decimal ValorPedidoCalcularComFreteComum)
            {
                Assert.That(TaxaFreteComum,
                    Is.EqualTo(freteComum.Calcula(
                        ValorPedidoCalcularComFreteComum)));
            }
        }
    }

