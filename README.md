# C# COMPLETO 2020 Programação Orientada a Objetos + Projetos

https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/

Curso mais didático e completo de C# e OO Projetos com UML, ASP.NET, Entity Framework, LINQ, Lambda e muito mais

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

#### 15 Tipos básicos de dados em C# - PARTE 1

![Tipos](/3-Secao-Recaptulacao-logica/img/01-tipos-c-sharp.png)

![Tipos String e Object](/3-Secao-Recaptulacao-logica/img/02-tipos-string.png)


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


- 17 Restrições e convenções para nomes
- 18 Saída de dados em C#

- 20 Conversão implícita e casting

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

- 21 Operadores aritméticos

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

- 22 Entrada de dados em C# - PARTE 1

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

- 23 Entrada de dados em C# - PARTE 2

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

- 25 Operadores comparativos

```csharp
int a = 10;
bool c1 = a < 10;
bool c2 = a < 20;
bool c3 = a > 10;
bool c4 = a > 5;
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);
Console.WriteLine("------------");
bool c5 = a <= 10;
bool c6 = a >= 10;
bool c7 = a == 10;
bool c8 = a != 10;
Console.WriteLine(c5);
Console.WriteLine(c6);
Console.WriteLine(c7);
Console.WriteLine(c8);
```

- 26 Operadores lógicos

```csharp
bool c1 = 2 > 3 || 4 != 5; // true
bool c2 = !(2 > 3) && 4 != 5; // true
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine("--------------");
bool c3 = 10 < 5; // false
bool c4 = c1 || c2 && c3; // true
Console.WriteLine(c3);
Console.WriteLine(c4);
```

- 27 Estrutura condicional (if-else)

```csharp
using System;
namespace Course {
        class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
```


```csharp
using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            double a, b, c, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}

```

- 30 Funções (sintaxe)


- 32 Estrutura repetitiva enquanto (while)

```csharp
using System;
using System.Globalization;
namespace Course {
class Program {
    static void Main(string[] args) {
        Console.Write("Digite um número: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (x >= 0.0) {
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
            Console.WriteLine("Número negativo!");
        }
    }
}
```

- for

```csharp
using System;
namespace Course {
class Program {
    static void Main(string[] args) {
        Console.Write("Quantos números inteiros você vai digitar? ");
        int N = int.Parse(Console.ReadLine());
        int soma = 0;
        for (int i = 1; i <= N; i++) {
            Console.Write("Valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
```


[Voltar ao Índice](#indice)

---


## <a name="parte4">4 - Classes, atributos, métodos, membros estáticos</a>


- 38 Resolvendo um problema sem orientação a objetos

```csharp
using System;
using System.Globalization;
namespace Course {
    class Program {
    static void Main(string[] args) {
        double xA, xB, xC, yA, yB, yC;
        Console.WriteLine("Entre com as medidas do triângulo X:");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com as medidas do triângulo Y:");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double p = (xA + xB + xC) / 2.0;
        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
        p = (yA + yB + yC) / 2.0;
        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        if (areaX > areaY) {
            Console.WriteLine("Maior área: X");
            }
                else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
```

- 43 Object e ToString
- 44 Terminando de construir o programa

```csharp
using System.Globalization;
namespace Course {
class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;
    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }
    public override string ToString() {
        return Nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
```

```csharp
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            
            int qte = int.Parse(Console.ReadLine());
            
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
```

- 47 Membros estáticos - PARTE 2

```csharp
namespace Course {
    class Calculadora {
        public static double Pi = 3.14;
        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
```

```csharp
Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",
CultureInfo.InvariantCulture));
```


[Voltar ao Índice](#indice)

---


## <a name="parte5">5 - Construtores, palavra this, sobrecarga, encapsulamento</a>

- 51 Construtores
  - É uma operação especial da classe, que executa no momento da instanciação do objeto
  - Usos comuns:
  - Iniciar valores dos atributos
  - Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência)
  - Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão:
  - Produto p = new Produto();
  - É possível especificar mais de um construtor na mesma classe (sobrecarga)

```csharp
using System.Globalization;
namespace Course {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
```

```csharp
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
```
![Construtor Melhorias Código Anterior](/5-Secao-Construtores-palavra-this-sobrecarga-encapsulamento/img/construtor-1.png)

```csharp
using System.Globalization;

namespace Contrutores
{
    public class Produto
    {
       public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque() {
         return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
```

```csharp
using System;
using System.Globalization;

namespace Contrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

```

- 52 Sobrecarga
  - É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com  diferentes listas de parâmetros.
- Proposta de melhoria
  - Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto A quantidade em estoque deste novo produto, por padrão, deverá então ser iniciada com o valor zero.
  - Nota: é possível também incluir um construtor padrão (sem parâmetros)

```csharp
  public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco){
            Nome = nome;
            Preco - preco;
            Quantidade = 0; // por padrão é adotado Zero 
        }

```

- 53 Sintaxe alternativa para inicializar valores

```csharp
public Produto() {
}
public Produto(string nome, double preco, int quantidade) {
    Nome = nome;
    Preco = preco;
    Quantidade = quantidade;
}
```

```csharp
Produto p = new Produto {
    Nome = "TV",
    Preco = 900.0,
    Quantidade = 0
};
Produto p2 = new Produto() {
    Nome = "TV",
    Preco = 900.0,
    Quantidade = 0
};
// Isso funciona mesmo se a classe não possuir construtores implementados
```

- 54 Palavra this 

- É uma referência para o próprio objeto
- Usos comuns:
  - Diferenciar atributos de variáveis locais (Java)
  - Referenciar outro construtor em um construtor
  - Passar o próprio objeto como argumento na chamada de um método ou construtor

![This](/5-Secao-Construtores-palavra-this-sobrecarga-encapsulamento/img/this.png)

- Referenciar outro construtor em um construtor

```csharp
public Produto() {
    Quantidade = 0;
}
public Produto(string nome, double preco) : this() {
    Nome = nome;
    Preco = preco;
}
public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
    Quantidade = quantidade;
}
```
- Passar o próprio objeto como argumento na chamada de um método ou construtor

```csharp
class ChessMatch {
(...)
    PlaceNewPiece('e', 1, new King(board, Color.White, this));
(...)
```

- 55 Encapsulamento
  - É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.
  - Regra de ouro: o objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso.
  
- Opção 1: implementação manual
  - Todo atributo é definido como private
  - Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio
  - Nota: não é usual na plataforma C#

```csharp
using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
            _nome = nome;
            }
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
```

- 56 Properties
  - São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos
  - https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
  - Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. As propriedades podem ser usadas como se fossem atributos públicos, mas na verdade elas são métodos especiais chamados "acessadores". Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos.

```csharp
    private string _nome;
    private double _preco;
    private int _quantidade;
    public Produto() {
    }
    public Produto(string nome, double preco, int quantidade) {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }
    public string Nome {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1) { // value = parametro
            _nome = value;
            }
        }
    }
    public double Preco {
        get { return _preco; }
    }
    public int Quantidade {
        get { return _quantidade; }
    }
    public double ValorTotalEmEstoque {
        get { return _preco * _quantidade; }
    }
    public void AdicionarProdutos(int quantidade) {
        _quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade) {
        _quantidade -= quantidade;
    }
    public override string ToString() {
        return _nome
        + ", $ "
        + _preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + _quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
    }
```

- 57 Auto Properties
  - É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações get e set.
  - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties


```csharp
using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; set; }
        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
```

- 58 Ordem sugerida para implementação de membros de classe
  - Atributos privados
  - Propriedades autoimplementadas
  - Construtores
  - Propriedades customizadas
  - Outros métodos da classe

- 59 Modificadores de acesso

- https://docs.microsoft.com/en-us/dotnet/csharp/languagereference/keywords/access-modifiers

![Membros](/5-Secao-Construtores-palavra-this-sobrecarga-encapsulamento/img/membros.png)

  - Classes
    - Acesso por qualquer classe
    - public class Product
    - Acesso somente dentro do assembly
    - internal class Product
    - class Product
    - Acesso somente pela classe-mãe
    - private class Product
    - Nota: classe aninhada, por padrão, é private

- 60 Exercício de fixação

Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).

Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

*Exemplo 1*
```
Entre o número da conta: 8532
Entre o titular da conta: Alex Green
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 500.00

Dados da conta:
Conta 8532, Titular: Alex Green, Saldo: $ 500.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 700.00

Entre um valor para saque: 300.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 395.00
```

*Exemplo 2*
```
Entre o número da conta: 7801
Entre o titular da conta: Maria Brown
Haverá depósito inicial (s/n)? n

Dados da conta:
Conta 7801, Titular: Maria Brown, Saldo: $ 0.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ 200.00

Entre um valor para saque: 198.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ -3.00
```


- 61 Correção do exercício - PARTE 1

- 62 Correção do exercício - PARTE 2
  
```csharp
using System;
using System.Globalization;

namespace Exercicio60
{
    public class ContaBancaria
    {
        public int Conta{get; private set;}
        public string Nome{get; set;}
        public double Saldo{get; private set;}

        public ContaBancaria(string nome, int conta)
        {
            Conta = conta;
            Nome = nome;
        }
        public ContaBancaria(string nome, int conta, double saldo) : this (nome, conta)
        {
            Saldo = saldo;
        }
        
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double retirada)
        {
            Saldo -= retirada + 5.0;
        }
        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
```


```csharp
using System;
using System.Globalization;

namespace Exercicio60
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaJose;

            Console.Write("Entre com o número da conta: ");
            int conta =  int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá Deposito Inicial?(s/n): ");
            char depInicial = char.Parse(Console.ReadLine());

            if(depInicial == 's' || depInicial == 'S'){
                Console.Write("Entre com o valor do Deposito: ");
                double saldo =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaJose = new ContaBancaria(nome, conta, saldo);
                Console.WriteLine(contaJose);
            }else{
                contaJose = new ContaBancaria(nome, conta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaJose);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaJose.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaJose);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaJose.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaJose);
          
            
            
        }
    }
}

```

[Voltar ao Índice](#indice)

---


## <a name="parte6">6 - Comportamento de memória, arrays, listas</a>

- 63 Visão geral do capítulo
- 64 Material de apoio do capítulo
  - [6-Comportamento-de-memoria-arrays-listas/00-materiais](/6-Comportamento-de-memoria-arrays-listas/00-materiais)
- 65 Aviso sobre conteúdo antigo
- 66 Tipos referência e tipos valor

Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim “tentáculos” (ponteiros) para caixas

![Tipos Referências](6-Comportamento-de-memoria-arrays-listas/img/comportamentos_variaveis_1.png)

Tipos referência aceitam o valor "null", que indica que a variável aponta pra ninguém.

![Tipos de referência](6-Comportamento-de-memoria-arrays-listas/img/comportamentos_variaveis_2.png)

**Structs são tipos valor**

A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e não ponteiros.

![Struct](6-Comportamento-de-memoria-arrays-listas/img/structs_1.png)

![Struct 2](6-Comportamento-de-memoria-arrays-listas/img/structs_2.png)

É possível criar seus próprios structs

```csharp
namespace Course {
    struct Point {
        public double X, Y;
        public override string ToString() {
            return "(" + X + "," + Y + ")";
        }
    }
}
```

```csharp
    Point p;
    Console.WriteLine(p); // erro: variável não atribuida
    p.X = 10;
    p.Y = 20;
    Console.WriteLine(p);

    p = new Point();
    Console.WriteLine(p);
```

**Valores padrão**

  - Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos
  - números: 0
  - bool: False
  - char: caractere código 0
  - objeto: null
  - Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.

**Tipos referência vs. tipos valor**

![Referências vs. Valor](6-Comportamento-de-memoria-arrays-listas/img/tipos_referencias_valor.png)


- 67 Desalocação de memória - garbage collector e escopo local

**Garbage collector**

- É um processo que automatiza o gerenciamento de memória de um programa em execução
- O garbage collector monitora os objetos alocados dinamicamente pelo programa (no heap), desalocando aqueles que não estão mais sendo utilizados.

![Garbage Collector](6-Comportamento-de-memoria-arrays-listas/img/garbageCollector_1.png)

![Garbage Collector](6-Comportamento-de-memoria-arrays-listas/img/garbageCollector_2.png)

![Garbage Collector](6-Comportamento-de-memoria-arrays-listas/img/garbageCollector_3.png)

- *Objetos alocados dinamicamente, quando não possuem mais referência para eles, serão desalocados pelo garbage collector*
- *Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução*


- 68 Nullable
- 69 Vetores - PARTE 1
- 70 Vetores - PARTE 2
- 71 Exercício de fixação (vetores)
- 72 Modificador de parâmetros params
- 73 Modificadores de parâmetros ref e out
- 74 Boxing e unboxing
- 75 Sintaxe opcional: laço foreach
- 76 Listas (List) - PARTE 1
- 77 Listas (List) - PARTE 2
- 78 Exercício de fixação (listas)
- 79 Matrizes
- 80 Exercício resolvido (matrizes)
- 81 Exercício de fixação (matrizes)
- 82 Conjuntos (aviso)

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

