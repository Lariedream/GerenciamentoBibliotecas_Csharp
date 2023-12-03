
//Criando uma classe // 

class Livro : ItemBiblioteca
{
    //propriedades//

    public string Autor {get; set;}

    // Construtor//
    public Livro(int id, string titulo, string autor): base(id,titulo)
    {
        Autor = autor;
        InicializarDescricaoInterna();
    }
    //metodo//

    public void InicializarDescricaoInterna()
    {
        DescricaoInterna = $"Livro escrito por {Autor}.";
    }

    public override void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição interna do {DescricaoInterna}");
    }
}