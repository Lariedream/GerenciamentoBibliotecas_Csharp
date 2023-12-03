
//Criando uma classe // 
abstract class ItemBiblioteca
{   

    //propriedades//
    public int Id {get; set;}
    public string Titulo {get; set;}
    protected string DescricaoInterna {get; set;}

    // construtor //
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão.";
    }
    // metodo abstrato //
    public abstract void ExibirDescricaoInterna();
}