using System.Globalization;
using System.Runtime.CompilerServices;
using ExemploExplorando.Models;
using Newtonsoft.Json;

////////// PARTE 14 - DESERIALIZAÇÃO
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

////////// PARTE 13 - SERIALIZAÇÃO
// DateTime dataAtual = DateTime.Now; // Padrão de data e hora para compatibilidade entre sistema, definida pela ISO 8601 "2024-08-18T11:51:17.9775454-03:00"
// List<Venda> listaVendas = new List<Venda>();
// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
// listaVendas.Add(v1);
// listaVendas.Add(v2);
// // Resultado na mesma linha
// // string serializado = JsonConvert.SerializeObject(v1);
// // Resultado com identação
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// // Grava em arquivo
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);

////////// PARTE 12
// int numero = 15;
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }
// Utilizando o IF Ternário
// int numero = 20;
// bool ehPar = false;
// ehPar = numero % 2 == 0; // O % retorna o módulo/sobra da divisão
// //-----------------------------------------  É par ?  Sim  :  Não
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

////////// PARTE 11 - Tuplas
// (int, string, string, decimal) tupla = (1, "Sílvio", "Silva", 1.74M);
// // ValueTuple<int, string,string, decimal> outroExemploTupla = (1, "Sílvio", "Silva", 1.74M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Sílvio", "Silva", 1.74M);
// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");
// LeituraArquivo arquivo = new LeituraArquivo();
// // Se não for usar uma informação da tupla, sibstitui por "_"
// // var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// if (sucesso)
// {
//     Console.WriteLine("Quantidade de Linhas do arquivo:" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }
// Método construtor
// Pessoa p1 = new Pessoa("Sílvio", "Silva");
// // Método desconstrutor (coloca em variáveis separadas)
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");

////////// PARTE 10 - Dictionary
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// // Pra acessar os valores das chaves
// // Console.WriteLine(estados["MG"]);
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("----------");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor Alterado";
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor Existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

////////// PARTE 09 - Pilha
// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

////////// PARTE 08 - Fila
// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

////////// PARTE 07 - Exemplo Exceção
// new ExemploExcecao().Metodo1();

////////// PARTE 06
// string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
// Console.WriteLine("Chegou até Aqui");
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
// Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até Aqui");
// }

////////// PARTE 05
// DateTime data = DateTime.Now;
// Converter texto em formato de data válida para o DateTime
// DateTime data = DateTime.Parse("17/04/2004 22:00");
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Somente a data
// Console.WriteLine(data.ToShortDateString());
// Somente a hora
// Console.WriteLine(data.ToShortTimeString());
// string dataString = "2004-04-32 18:00";
// // DateTime data = DateTime.Parse(dataString);
// bool sucesso = DateTime.TryParseExact(dataString,
//                                       "yyyy-MM-dd HH:mm",
//                                       CultureInfo.InvariantCulture,
//                                       DateTimeStyles.None,
//                                       out DateTime data);
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

////////// PARTE 04
// // Para setar as configurações Globais para uma em específico
// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1582.40M;
// // :C no final pega a Currency Local (Moeda Local, Regional) onte está configurado o seu S.O. 
// Console.WriteLine($"{valorMonetario:C}");
// // :N no final considera só a parte numérica
// Console.WriteLine($"{valorMonetario:N}");
// // Se estiver travado pelo sistema global, pode criar uma cultura específica
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// // Porcentagem %
// double porcentagem =.3421;
// Console.WriteLine(porcentagem.ToString("P"));
// // Formatos personalizados
// int numero = 12345678;
// Console.WriteLine(numero.ToString("##-##-##/##"));

////////// PARTE 03
// string numero1 = "10";
// int numero2 = 20;
// // string numero1 = "10";
// // string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

////////// PARTE 02
// Pessoa p1 = new Pessoa("Sílvio", "Silva");
// Pessoa p2 = new Pessoa(nome: "Lucélia", sobrenome: "Silva");
// // Pessoa p1 = new Pessoa();
// // p1.Nome = "Sílvio";
// // p1.Sobrenome = "Silva";

// // Pessoa p2 = new Pessoa();
// // p2.Nome = "Lucélia";
// // p2.Sobrenome = "Garcia da Silva";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

////////// PARTE 01
// Pessoa p1 = new Pessoa();
// p1.Nome = "Sílvio";
// p1.Sobrenome = "Silva";
// p1.Idade = 42;
// p1.Apresentar();
