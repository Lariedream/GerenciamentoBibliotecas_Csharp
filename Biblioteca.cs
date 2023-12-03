//Criando uma classe // 

class Biblioteca
{
    //lista//
    private List<ItemBiblioteca> colecao;

    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Metodo para adicionar
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Metodo para remover
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // sobrecarga de metodos
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        return colecao.Find(item => item.Titulo == titulo);
    }

    // sobrecarga de metodos
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.Id == id);
    }

    
}