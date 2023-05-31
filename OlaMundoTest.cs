using System;
namespace test
{
	public class OlaMundoTest
	{
        [Test]
        public void TestarRetornoVazioOlaMundo()
        {
            var esperado = "Olá, Mundo";
            var resultado = new OlaMundo().Ola(null, "Portugues");
            Validar(resultado, esperado);
        }

        [Test]
        public void TestarRetornoComNomeRepassado()
        {
            var esperado = "Olá, Joao";
            var resultado = new OlaMundo().Ola("Joao", "Portugues");
            Validar(resultado, esperado);
        }

        [Test]
        public void TestarRetornoComNomeRepassadoComIdiomaEspanhol()
        {
            var esperado = "Hola, Elodie";
            var resultado = new OlaMundo().Ola("Elodie", "Espanhol");
            Validar(resultado, esperado);
        }

        public void Validar(String resultado,String esperado)
        {
           Assert.That(resultado, Is.EqualTo(esperado));
        }
    }
}

