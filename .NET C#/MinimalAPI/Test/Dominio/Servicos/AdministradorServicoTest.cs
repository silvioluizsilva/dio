using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Test.Dominio.Entidades;

[TestClass]
public class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTest()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location());
        var path = Path.GetFullPath(Path.Combine.assemblyPath ?? "", "..", "..");

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsetings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

            var configuration = builder.Build();

            return new DbContexto(configuration);
    }

    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        //Arrange
        var context = CriarContextoDeTest();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        var context = CriarContextoDeTest();
        var administradorServicoTest = new AdministradorServicoTest(context);

        // Act
        administradorServicoTest.Incluir(adm);

        // Assert
        Assert.AreEqual(1, administradorServicoTest.Todos(1).Count());
    }

    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

        var adm = new Administrador();
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        var administradorServico = new AdministradorServico(context);

        // Act
        administradorServico.Incluir(adm);
        var admDoBanco = administradorServico.BuscaPorId(adm.Id);

        // Assert
        Assert.AreEqual(1, admDoBanco?.Id);
    }

    [TestMethod]
    public void TestandoBuscaTodosAdministradores()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

        var administradores = new List<Administrador>()
        {
            new Administrador { Email = "mateus@test.com", Senha = "mateustest", Perfil = "Adm" },
            new Administrador { Email = "marcos@test.com", Senha = "marcostest", Perfil = "Editor" },
            new Administrador { Email = "lucas@test.com", Senha = "lucastest", Perfil = "Editor" },
        };

        administradores.ForEach(adm => context.Administradores.Add(adm));
        context.SaveChanges();

        var administradorServico = new AdministradorServico(context);

        // Act
        var listaAdministradores = administradorServico.Todos(null); 

        // Assert
        Assert.AreEqual(3, listaAdministradores.Count); 
    }

 
}