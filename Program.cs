Biblioteca objetoBiblioteca = new Biblioteca();



Livro objetolivro = new Livro(1, "A culpa é das estrelas", "John Green");
Livro objetolivro2 = new Livro(2, "Inferno", "Dan Brown");

objetoBiblioteca.AdicionarItem(objetolivro);
objetoBiblioteca.AdicionarItem(objetolivro2);


//buscando livro por titulo, metodo//
Livro livroEncontrado = (Livro)objetoBiblioteca.BuscarItemPorTitulo("Inferno");
Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo} - Autor: {livroEncontrado.Autor}");
// Exibir a descrição interna do livro
objetolivro2.ExibirDescricaoInterna();

//buscando livro por id, metodo//
Livro livroEncontradoId = (Livro)objetoBiblioteca.BuscarItemPorId(1);
Console.WriteLine($"Livro encontrado: {livroEncontradoId.Titulo} - Autor: {livroEncontradoId.Autor}");
// Exibir a descrição interna do livro
objetolivro.ExibirDescricaoInterna();


// Remover livro da biblioteca
objetoBiblioteca.RemoverItem(objetolivro);
