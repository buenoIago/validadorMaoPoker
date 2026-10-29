namespace TestProject1;

[TestClass]
public sealed class CartasTest
{
    [TestMethod]
    public void validarValorCartaValida()
    {
        var cartas = new CartasPoker();

        var resultado = cartas.ValidarCarta("3C");

        Assert.AreEqual("Carta válida", resultado);
    }

    [TestMethod]
    public void validarValorCartaInvalida()
    {
        var cartas = new CartasPoker();

        var resultado = cartas.ValidarCarta("1C");

        Assert.AreEqual("Carta Inválida", resultado);
    }
}
