# C# COMPLETO 2020 Programação Orientada a Objetos + Projetos

https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/

Curso mais didático e completo de C# e OO. Projetos com UML, ASP.NET, Entity Framework, LINQ, Lambda e muito mais

## <a name="indice">Índice</a>

1. [Apresentação do curso e orientações](#parte1)     
2. [Introdução a C# e .NET](#parte2)     
3. [Recapitulação de Lógica de Programação usando C#](#parte3)     
4. [Classes, atributos, métodos, membros estáticos](#parte4)     
5. [Construtores, palavra this, sobrecarga, encapsulamento](#parte5)     
6. [Comportamento de memória, arrays, listas](#parte6)     
7. [Tópicos especiais em C# - PARTE 1](#parte7)     
8. [Introdução ao Git e Github](#parte8)     
9. [Enumerações e composição](#parte9)     
10. [Herança e polimorfismo](#parte10)     
11. [Tratamento de exceções](#parte11)     
12. [Projeto: Sistema de jogo de xadrez](#parte12)     
13. [Trabalhando com arquivos](#parte13)     
14. [Interfaces](#parte14)     
15. [Tópicos especiais em C# - PARTE 2](#parte15)     
16. [Expressões lambda, delegates, LINQ](#parte16)     
17. [Projeto: Sistema Web com ASP .NET Core MVC e Entity Framework](#parte17)     
18. [Seção bônus](#parte18)     
---


## <a name="parte1">1 - Apresentação do curso e orientações</a>



[Voltar ao Índice](#indice)

---


## <a name="parte2">2 - Introdução a C# e .NET</a>



[Voltar ao Índice](#indice)

---


## <a name="parte3">3 - Recapitulação de Lógica de Programação usando C#</a>

#### 15. Tipos básicos de dados em C# - PARTE 1

![Tipos](3-Secao-Recaptulacao-logica\img\01-tipos-c-sharp.png)

![Tipos String e Object](3-Secao-Recaptulacao-logica\img\02-tipos-string.png)


- Demostrações

```csharp
bool completo = false;
char genero = 'F';
char letra = '\u0041';
byte n1 = 126;
int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L;
float n5 = 4.5f;
double n6 = 4.5;
String nome = "Maria Green";
Object obj1 = "Alex Brown";
Object obj2 = 4.5f;
Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(letra);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(nome);
Console.WriteLine(obj1);
Console.WriteLine(obj2);
```

Funções para valores mínimos e máximos

- int.MinValue
- int.MaxValue
- sbyte.MaxValue
- long.MaxValue
- decimal.MaxValue
- etc...


- 17. Restrições e convenções para nomes
- 18. Saída de dados em C#

- 20. Conversão implícita e casting

```csharp
double a;
float b;
a = 5.1;
b = (float)a;
Console.WriteLine(b);
```

```csharp
double a;
int b;
a = 5.1;
b = (int)a;
Console.WriteLine(b);

```

- 21. Operadores aritméticos

```csharp
int n1 = 3 + 4 * 2;
int n2 = (3 + 4) * 2;
int n3 = 17 % 3;
double n4 = 10.0 / 8.0;
double a = 1.0, b = -3.0, c = -4.0;
double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);
```

- 22. Entrada de dados em C# - PARTE 1

```csharp
using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int y;
            double z;
            char w;            

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}
```

- 23. Entrada de dados em C# - PARTE 2

```csharp
using System;
using System.Globalization;

namespace EntradaDeDados02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

```

- Exercício de fixação

```csharp
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
```


[Voltar ao Índice](#indice)

---


## <a name="parte4">4 - Classes, atributos, métodos, membros estáticos</a>



[Voltar ao Índice](#indice)

---


## <a name="parte5">5 - Construtores, palavra this, sobrecarga, encapsulamento</a>



[Voltar ao Índice](#indice)

---


## <a name="parte6">6 - Comportamento de memória, arrays, listas</a>



[Voltar ao Índice](#indice)

---


## <a name="parte7">7 - Tópicos especiais em C# - PARTE 1</a>



[Voltar ao Índice](#indice)

---


## <a name="parte8">8 - Introdução ao Git e Github</a>



[Voltar ao Índice](#indice)

---


## <a name="parte9">9 - Enumerações e composição</a>



[Voltar ao Índice](#indice)

---


## <a name="parte10">10 - Herança e polimorfismo</a>



[Voltar ao Índice](#indice)

---


## <a name="parte11">11 - Tratamento de exceções</a>



[Voltar ao Índice](#indice)

---


## <a name="parte12">12 - Projeto: Sistema de jogo de xadrez</a>



[Voltar ao Índice](#indice)

---


## <a name="parte13">13 - Trabalhando com arquivos</a>



[Voltar ao Índice](#indice)

---


## <a name="parte14">14 - Interfaces</a>



[Voltar ao Índice](#indice)

---


## <a name="parte15">15 - Tópicos especiais em C# - PARTE 2</a>



[Voltar ao Índice](#indice)

---


## <a name="parte16">16 - Expressões lambda, delegates, LINQ</a>



[Voltar ao Índice](#indice)

---


## <a name="parte17">17 - Projeto: Sistema Web com ASP .NET Core MVC e Entity Framework</a>



[Voltar ao Índice](#indice)

---


## <a name="parte18">18 - Seção bônus</a>



[Voltar ao Índice](#indice)

---

