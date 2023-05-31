using NSubstitute;

namespace test;

public interface SomaInterface
{
    int Somar(int a, int b);
}

public class Tests : SomaInterface
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    [TestCase(3, 3, 6, TestName = "Somatoria 3 e 3 com o retorno 6")]
    [TestCase(-3, 1, -2, TestName = "Somatoria -3 e 1 com o retorno -2")]
    [TestCase(3, -1, 2, TestName = "Somatoria 3 e -1 com o retorno 2")]
    [TestCase(-3, -1, -4, TestName = "Somatoria -3 e -1 com o retorno -4")]
    public void Somatoria(int entradaA, int EntradaB, int esperado)
    {
        var soma = Somar(entradaA, EntradaB);
        Assert.AreEqual(esperado, soma);
    }

    [TestCaseSource(nameof(SomatoriaCases))]
    public void SomatoriaMock(int entradaA, int EntradaB, int esperado)
    {
        var soma = Somar(entradaA, EntradaB);
        Assert.AreEqual(esperado, soma);
    }

    [Test]
    [Repeat(25)]
    public void SomaMock()
    {
        var mock = Substitute.For<SomaInterface>();
        mock.Somar(2, 2).Returns(5);
        Assert.That(mock.Somar(2, 2), Is.EqualTo(5));
    }

    private static object[] SomatoriaCases =
    {
    new object[] { 1, 1, 2 },
    new object[] { -1, 2, 1 },
    new object[] { 1, -2, -1 },
    new object[] { -1, -2, -3 }
};
}