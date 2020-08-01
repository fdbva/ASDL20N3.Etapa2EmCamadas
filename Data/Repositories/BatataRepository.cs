using Domain.Model.Interfaces.Repositories;

namespace Data.Repositories
{
    public class BatataRepository : IBatataRepository
    {
        public static int Estoque = 30;

        public BatataRepository()
        {
            Estoque++;
        }

        public int ObterQuantidade()
        {
            return Estoque;
        }

        public void ReduzirQuantidade(int quantidadeVendida)
        {
            Estoque -= quantidadeVendida;
        }
    }
}
