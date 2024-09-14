using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "Fusca";
        veiculo.Marca = "Wolks";
        veiculo.Ano = 1970;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Fusca", veiculo.Nome);
        Assert.AreEqual("Wolks", veiculo.Marca);
        Assert.AreEqual(1970, veiculo.Ano);
    }
}
