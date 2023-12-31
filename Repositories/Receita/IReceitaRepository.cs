public interface IReceitaRepository
{
    List<Receita> Read();
    Receita Read(int id);
    void Create(Receita receita, Categoria categoria);
    void Delete(int id);
    void Update(Receita receita, int id);
}