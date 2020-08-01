namespace Domain.Model.Interfaces.Repositories
{
    public interface IBatataRepository
    {
        int ObterQuantidade();
        void ReduzirQuantidade(int quantidadeVendida);
    }
}
