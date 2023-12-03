# GerenciamentoBibliotecas_Csharp

Abordagem:

Classe Base Abstrata (ItemBiblioteca):
Propriedades: Id (int), Título (string), DescricaoInterna (protegida) (string).
Construtor: Inicializa Id e Título, define um valor padrão para DescricaoInterna.
Método Abstrato: ExibirDescricaoInterna().


Classe Derivada (Livro):
Herda de ItemBiblioteca.
Propriedade adicional: Autor (string).
Construtor: Recebe Id, Título e Autor, inicializa DescricaoInterna.
Método Implementado: ExibirDescricaoInterna().


Classe Biblioteca:
Gerencia uma coleção de ItemBiblioteca.
Métodos: AdicionarItem, RemoverItem, BuscarItemPorTitulo (sobrecarregado), BuscarItemPorId (sobrecarregado).


Classe Program:
Ponto de entrada.
Cria instâncias de Biblioteca e Livro.
Demonstração de adição, busca e remoção de livros.
Exibição da DescricaoInterna do livro.

Conceitos de POO Utilizados:

Herança: Utilizada na classe Livro para reutilização de propriedades e métodos da classe base.
Polimorfismo: Método ExibirDescricaoInterna é abstrato na classe base e implementado nas classes derivadas.
Encapsulamento: Uso de propriedades, métodos e modificadores de acesso protegidos para controlar o acesso aos membros das classes.
Sobrecarga de Métodos: Métodos BuscarItemPorTitulo e BuscarItemPorId na classe Biblioteca permitem busca por título ou Id.
