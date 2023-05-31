using System;
namespace test
{
    public class OlaMundo
	{
		public const String prefixoOlaPortugues = "Olá, ";

        public String? Ola(String nome, String idioma) {
			if (nome == null)
				nome = "Mundo";

            if (idioma.ToLower() == "Espanhol".ToLower()) {
                return "Hola, " + nome;
            }

            return prefixoOlaPortugues + nome;

        }
    }
}

