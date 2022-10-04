using ExemploFundamentos.Common.Models;


//Lista

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


Console.WriteLine($"Itens da Lista {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens da Lista {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens da Lista {listaString.Count} - Capacidade: {listaString.Capacity}");




// Console.WriteLine("Percorrendo lista com FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//   Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo Lista com FOREACH");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//   Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//   contadorForeach++;
// }




//Array

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //ArgumentOutOfRangeException a capacidad de elemetos do array

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }





// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros) // Foreach sig: para cada, apenas para listas e array
// {
//   Console.WriteLine($"Posição Nº {contadorForeach} -{valor}");
//   contadorForeach++;
// }


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Rafael";
// pessoa1.Idade = 37;
// pessoa1.Apresentar();


// // //Aula 20
// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//   Console.Clear();
//   Console.WriteLine("Digite a sua opção: ");
//   Console.WriteLine("1 - Cadastrar Cliente");
//   Console.WriteLine("2 - Buscar Cliente");
//   Console.WriteLine("3 - Apagar Cliente");
//   Console.WriteLine("4 -Encerrar");

//   opcao = Console.ReadLine();

//   switch (opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de Cliente");
//       break;
//     case "2":
//       Console.WriteLine("Busca de Cliente");
//       break;
//     case "3":
//       Console.WriteLine("Apagar de Cliente");
//       break;
//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false; //bool exibirMenu = true; while (exibirMenu)
//       //Enviroment.Exit(0); Sair sem executar mais nada. através do While(true)
//       break;

//     default:
//       Console.Write("Opção Inválida");
//       break;
//   }
// }
// Console.WriteLine("O Programa se Encerrou");


//Aula 19
//DO While

// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um número (0 para Parar) ");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;
// } while (numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//Aula 18

// int numero = 5;
// int contador = 1;


// while (contador <= 10)
// {
//   Console.WriteLine($"{contador}° Execução... {numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6)
//   {
//     break;
//   }
// }



//Aula 17

//FOR
// int numero = 5;


// for (int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


//Aula 16

//  Calculadoras calc = new Calculadoras();

// calc.RaizQuadrada(10);


//Aula 15

// int numeroI = 10;

// Console.WriteLine($"O número a ser incrementado é {numeroI}");

// Console.WriteLine("Incrementando valor ao 10");
// numeroI++;

// Console.WriteLine(numeroI);

// int numeroD = 20;

// Console.WriteLine($"O número a ser decrementado é {numeroD}");

// Console.WriteLine("Decrementando valor ao 10");
// numeroD--;

// Console.WriteLine(numeroD);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);


// calc.Potencia(3, 3);


// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

//Aula 14

// Console.WriteLine("Digite um letra: ");
// string letra = Console.ReadLine(); // Para usuário digitar um valor e após digitar enter

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é Vogal");
//     break;
// }

//Aula 13

// Console.WriteLine("Digite um letra: ");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")

// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é uma Vogal");
// }


//Aula 12

// Console.WriteLine("Digite um letra: ");
// string letra = Console.ReadLine();


// if (letra == "a")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é Vogal");
// }


//Aula 11

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda} ");

// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda) //condição
// {
//   Console.WriteLine("Venda realizada...");
// }
// else
// {
//   Console.WriteLine("Desculpe Não temos a quantidade desejada em estoque...");
// }


//Aula 010

// string a = "15-";

// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizado com sucesso!");

//Aula 09

// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizado com sucesso!");



//Aula 08
// string a = "15";

// int b = Convert.ToInt32(a);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizado com sucesso!" + b);



// double a = 4 / 2 + 2;
// double b = 4 / (2 + 2);
// Console.WriteLine(a);
// Console.WriteLine(b);

//Aula 07

// int a = 5;
// double b = a;

// long a =  long.MaxValue;
// int b = Convert.ToInt32(a);
// erro o max de long é trillhões e maximo de Int32 é bilhões


// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);



//Aula 06

// int inteiro = 5;
// string a = inteiro.ToString();
// // todo tipo pode ser convertido para String através do ToString devido que o mesmo está contido em todos os tipos

// Console.WriteLine(a);



// // Processo Cast -- Casting
// int a = Convert.ToInt32(null); // Convert aceita null retorna o valor 0

// //int a = int.Parse(null); // Parse não aceita nulo

// Console.WriteLine(a);


//Aula 05
// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5;

// // c += 5;
// c -= 5;

//Aula 04
// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now; //Hora atual
// DateTime dataAtual1 = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // imprime somente o for descrito no Tostring
// Console.WriteLine(dataAtual1);



//Aula 03
// string apresentacao = "Olá, seja Bem vindo..";

// int quantidade = 1;
// quantidade = 10; // subescreve primeiro valor de int, não usar o int para subescrever 

// double altura = 1.80;

// decimal preco = 1.80M;  // valores monetarios

// bool condicao = true;



//Aula 02
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantide: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00")); // tratamento decimal
// Console.WriteLine("Valor da variavel preço: " + preco);
// Console.WriteLine("Valor da variavel condição: " + condicao);

//Aula 01

// //Pessoa pessoa1 = new Pessoa();

// //pessoa1.Nome = "Rafael";
// //pessoa1.Idade = 37;
// //pessoa1.NomeRepresentanteLegal = "João";
// pessoa1.Apresentar();



