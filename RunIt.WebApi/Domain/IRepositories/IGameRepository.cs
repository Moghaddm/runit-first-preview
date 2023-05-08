namespace RunIt.WebApi.Domain.IRepositories;
public interface IGameRepository
{
    IEnumerable<Game> Get();
    IEnumerable<Game> GetByName(string name);
    ValueTask IncreaseRate();
    ValueTask DecreaseRate();

}