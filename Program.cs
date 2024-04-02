using System;

class Program
{
    static void Main(string[] args)
    {
        Menu(); // Função Menu
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Seja bem Vindo(a) a minha calculadora feita em C Sharp ! "); // Boas vindas ao usuário
        Console.WriteLine("Escolha a opção de cálculo desejado :");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");                              // Menu da calculadora
        Console.WriteLine("3- Divisão");
        Console.WriteLine("4- Multiplicação");
        Console.WriteLine("5- Raíz Quadrada");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Selecione o número da opção : ");
        short? res = short.Parse(Console.ReadLine()!);                  // Escolha do usuário 
        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;             
            case 5: RaizQuadrada(); break;
            case 4: Multiplicacao(); break;          // Menu das funções 
            case 6: System.Environment.Exit(0); break;
            default:Menu(); break;
        }
    }
    static void Soma()

    {
        Console.Clear();
        Console.WriteLine("Escolha o primeiro valor : ");                        // Requisição de dados ao usuário
        float? valor1 = float.Parse(Console.ReadLine()!);                        // Captação dos dados e conversão para variável tipo float
        Console.WriteLine("Certo, agora escolha o segundo valor : ");            // Requisição de dados ao usuário
        float? valor2 = float.Parse(Console.ReadLine()!);                        // Captação dos dados e conversão para variável tipo float
        float? soma = valor1 + valor2;                                           // Cálculo da soma 
        Console.WriteLine(" ");
        Console.WriteLine($"O resultado da soma do seu cálculo é {soma} .");     // Output para o usuário
        Console.WriteLine("----------------------------");        
        Console.WriteLine("Deseja fazer outro cálculo ?");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()

    {
        Console.Clear();
        Console.WriteLine("Escolha o primeiro valor o cálculo: ");                                   // Requisição de dados ao usuário
        float? valor1 = float.Parse(Console.ReadLine()!);                                   // Captação dos dados e conversão para variável tipo float
        Console.WriteLine("Certo, agora escolha o segundo valor : ");                       // Requisição de dados ao usuário
        float? valor2 = float.Parse(Console.ReadLine()!);                                   // Captação dos dados e conversão para variável tipo float
        float? subtracao = valor1 - valor2;                                                 // Cálculo da subtração
        Console.WriteLine(" ");
        Console.WriteLine($"O resultado da subtração do seu cálculo é {subtracao} .");      // Output para o usuário
        Console.WriteLine("----------------------------");
        Console.WriteLine("Deseja fazer outro cálculo ?");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Escolha o primeiro valor o cálculo : ");                                       // Requisição de dados ao usuário
        float? valor1 = float.Parse(Console.ReadLine()!);                                       // Captação dos dados e conversão para variável tipo float
        Console.WriteLine("Certo, agora escolha o segundo valor : ");                           // Requisição de dados ao usuário
        float? valor2 = float.Parse(Console.ReadLine()!);                                       // Captação dos dados e conversão para variável tipo float
        float? divisao = valor1 / valor2;                                                       // Calculo da divisão
        Console.WriteLine(" ");
        Console.WriteLine($"O resultado da divisão do seu cálculo é {divisao} .");              // Output para o usuário
        Console.WriteLine("----------------------------");
        Console.WriteLine("Deseja fazer outro cálculo ?");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Escolha o primeiro valor para o cálculo : ");                        // Requisição de dados ao usuário
        float? valor1 = float.Parse(Console.ReadLine()!);                                       // Captação dos dados e conversão para variável tipo float
        Console.WriteLine("Certo, agora escolha o segundo valor : ");                           // Requisição de dados ao usuário
        float? valor2 = float.Parse(Console.ReadLine()!);                                       // Captação dos dados e conversão para variável tipo float
        float? multiplicacao = valor1*valor2;
        Console.WriteLine(" ");                                                                 // Calculo da multiplicação
        Console.WriteLine($"O resultado da multiplicação do seu cálculo é {multiplicacao} .");  // Output para o usuário
        Console.WriteLine("----------------------------");
        Console.WriteLine("Deseja fazer outro cálculo ?");
        Menu();
    }
    static void RaizQuadrada()
    {
        Console.Clear();
        Console.WriteLine("Escolha o valor para o cálculo : ");                                 // Requisição de dados ao usuário
        double valor1 = double.Parse(Console.ReadLine()!);                                      // Captação dos dados e conversão para variável tipo float                                     // Captação dos dados e conversão para variável tipo float
        double raizQuadrada = Math.Sqrt(valor1);                                                // Cálculo para raíz quadrada
        Console.WriteLine(" ");
        Console.WriteLine($"A raíz quadrada é {raizQuadrada} .");   // Output para o usuário
        Console.WriteLine("----------------------------");
        Console.WriteLine("Deseja fazer outro cálculo ?");
        Console.ReadKey();
        Menu();
    }

}