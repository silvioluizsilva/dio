using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Test.Domain.Servicos;

[TestClass]
public class VeiculoServicoTest
{
    private DbContexto CriarContextoDeTeste(){
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration =builder.Build();

        return new DbContexto(configuration);
    }

    [TestMethod]
    public void TestandoSalvarVeiculo()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo();
        veiculo.Nome = "Fusca";
        veiculo.Marca = "Wolks";
        veiculo.Ano = 1970;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(veiculo);

        // Assert
        Assert.AreEqual(1, veiculoServico.Todos(1).Count());
    }

    [TestMethod]
    public void TestandoApagarVeiculo()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo { Nome = "Fusca", Marca = "Wolks", Ano = 1970 };
        context.Veiculos.Add(veiculo);
        context.SaveChanges();

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Apagar(veiculo);

        // Assert
        var veiculoApagado = veiculoServico.BuscaPorId(veiculo.Id);
        Assert.IsNull(veiculoApagado);
    }

    [TestMethod]
    public void TestandoAtualizarVeiculo()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo { Nome = "Fusca", Marca = "Wolks", Ano = 1970 };
        context.Veiculos.Add(veiculo);
        context.SaveChanges();

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculo.Nome = "Corsa";
        veiculoServico.Atualizar(veiculo);

        // Assert
        var veiculoAtualizado = veiculoServico.BuscaPorId(veiculo.Id);
        Assert.AreEqual("Corsa", veiculoAtualizado?.Nome);
    }
    
    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo();
        veiculo.Nome = "Fusca";
        veiculo.Marca = "Wolks";
        veiculo.Ano = 1970;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(veiculo);
        var veiculoDoBanco = veiculoServico.BuscaPorId(veiculo.Id);

        // Assert
        Assert.AreEqual(1, veiculoDoBanco?.Id);
    }

    [TestMethod]
    public void TestandoBuscaTodosVeiculos()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculos = new List<Veiculo>()
        {
            new Veiculo { Nome = "Fusca", Marca = "Wolks", Ano = 1970 },
            new Veiculo { Nome = "Passat", Marca = "Wolks", Ano = 1984 },
            new Veiculo { Nome = "Premio", Marca = "Fiat", Ano = 1995 },
        };

        veiculos.ForEach(veiculo => context.Veiculos.Add(veiculo));
        context.SaveChanges();

        var veiculoServico = new VeiculoServico(context);

        // Act
        var listaVeiculos = veiculoServico.Todos(null); 

        // Assert
        Assert.AreEqual(3, listaVeiculos.Count); 
    }

    [TestMethod]
    public void TestandoBuscaTodosVeiculosPaginado()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculos = new List<Veiculo>()
        {
            new Veiculo { Nome = "Fusca", Marca = "Wolks", Ano = 1970 },
            new Veiculo { Nome = "Passat", Marca = "Wolks", Ano = 1984 },
            new Veiculo { Nome = "Premio", Marca = "Fiat", Ano = 1995 },
            new Veiculo { Nome = "Opala", Marca = "Chevrolet", Ano = 1986 },
            new Veiculo { Nome = "Parati", Marca = "Wolks", Ano = 1989 },
        };

        veiculos.ForEach(veiculo => context.Veiculos.Add(veiculo));
        context.SaveChanges();

        var veiculoServico = new VeiculoServico(context);

        // Act
        var pagina1 = veiculoServico.Todos(1); 
        var pagina2 = veiculoServico.Todos(2);

        int itemsPorPagina = 3;
        // Assert
        Assert.AreEqual(3, pagina1.Count); 
        Assert.AreEqual(2, pagina2.Count);
        Assert.AreEqual(veiculos[0].Nome, pagina1[0].Nome);
        Assert.AreEqual(veiculos[1].Nome, pagina1[1].Nome);
        Assert.AreEqual(veiculos[2].Nome, pagina1[2].Nome);
        Assert.AreEqual(veiculos[3].Nome, pagina2[0].Nome);
        Assert.AreEqual(veiculos[4].Nome, pagina2[1].Nome);
    }
}
