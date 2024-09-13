using ExemplosFundamentosCommon.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");





// Console.WriteLine($"Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }
// Console.WriteLine($"Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }




////////// PARTE 25 - Laços de repetição com listas
// // int[] arrayInteiros = new int[3];
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1; // Estouro da capacidade do array int[3] / contador 4
// int[] arrayInteiroDobrado = new int[arrayInteiros.Lenght * 2];
// Array.Copy(origem, destino, posições que serão copiadas)
// Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Lenght);
// // Percorrendo o array com o FOR
// Console.WriteLine($"Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }
// // Percorrendo o array com o FOREACH - Variavel contador apenas para fazer o tratamento da posição externamente, pois o foreach não tem contador
// int contadorForeach = 0;
// Console.WriteLine($"Percorrendo o Array com o FOREACH");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }
// // Para redimensionar um array: Array.Resize(ref arrayInteiros, arrayInteiros.Lenght * 2 + 2);

////////// PARTE 24 - Menu Interativo
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Sílvio";
// pessoa1.Idade = 42;
// pessoa1.Apresentar();

////////// PARTE 23 - Menu Interativo
// string? opcao;
// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");
//     opcao = Console.ReadLine();
//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }
// } 


























////////// PARTE 22 - Estruturas de Repetição
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// } while (numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é : {soma}");

////////// PARTE 21 - Estruturas de Repetição
// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     // Console.WriteLine($"{contador}º Execução: {numero} = {numero * contador}"); //Contador de execuções inicia do zero
//     Console.WriteLine($"{contador + 1}º Execução: {numero} = {numero * contador}"); //Contador de execuções inicia do um
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

////////// PARTE 20 - Estruturas de Repetição
// int numero = 5;
// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

////////// PARTE 19 - Raiz Quadrada
// Calculadora calc = new Calculadora();
// calc.RaizQuadrada(9);

////////// PARTE 18 - Incremento e Decremento
// int numeroIncremento = 10;
// Console.WriteLine("Incrementando o 10:");
// Console.WriteLine(numeroIncremento);
// numeroIncremento = numeroIncremento + 1;
// numeroIncremento++;
// Console.WriteLine($"Resultado: {numeroIncremento}");
// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20:");
// numeroDecremento = numeroDecremento -1;
// numeroDecremento--;
// Console.WriteLine($"Resultado: {numeroDecremento}");

////////// PARTE 17 - Operadores Aritméticos
// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2,2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

////////// PARTE 16 - Operador Lógico "NOT"
// bool choveu = false;
// bool estaTarde = false;
// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

////////// PARTE 15 - Operador Lógico "AND"
// bool possuiPresencaoMinima = true;
// double media = 7.5;
// if (possuiPresencaoMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else{
//     Console.WriteLine("Reprovado");
// }

////////// PARTE 14 - Operador Lógico "OR"
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else{
//     Console.WriteLine("Entrada não liberada");
// }

////////// PARTE 13
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma Vogal");
//         break;
// }

////////// PARTE 12
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
//     {
//         Console.WriteLine("Vogal");
//     }
//     else{
//         Console.WriteLine("Não é uma vogal.");
//     }

////////// PARTE 12
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é uma vogal.");
// }

////////// PARTE 11
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

////////// PARTE 10
// string a = "15-"; // ERRO com o sinal -
// // int b = 0;
// int.TryParse(a, out int b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

////////// PARTE 09
// double a = 4 / (2 + 2);
// Console.WriteLine(a);

////////// PARTE 08
//Cast implícito
// int a = 5;
// double b = a;
// Console.WriteLine(b);
//////////
// int a = 5;
// long b = a;
// Console.WriteLine(b);

////////// PARTE 08
// int inteiro = 5;
// string a = inteiro.ToString();

////////// PARTE 07
// Cast ou Casting
// int a = Convert.ToInt32(null); // Zero
// int a = int.Parse(null);       // Erro
// Console.WriteLine(a);

////////// PARTE 06
// Cast ou Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

////////// PARTE 05
// int a = 10;
// int b = 20;
// int c = a + b;

// //c = c + 5;
// //c += 5;
// //c = c - 5;
// c -= 5;
// Console.WriteLine(c);

////////// PARTE 04
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

////////// PARTE 03
// string apresentacao = "Olá, seja bem vindo!";
// double altura = 1.80;
// decimal preco = 1.80M; //O "M" é uma referencia para representar exatamente como decimal
// bool condicao = true;
// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

////////// PARTE 02
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

////////// PARTE 01
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Sílvio";
// pessoa1.Idade = 42;
// pessoa1.Apresentar();