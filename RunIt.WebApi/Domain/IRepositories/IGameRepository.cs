namespace RunIt.WebApi.Domain.IRepositories;
public interface IGameRepository
{
    ValueTask<IEnumerable<Game>> Get();
    ValueTask<IEnumerable<Game>> GetByName(string fullName);
    ValueTask<Game> GetById(int productId);
    ValueTask IncreaseRate(int productId);
    ValueTask DecreaseRate(int productId);

}