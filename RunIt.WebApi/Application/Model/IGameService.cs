using RunIt.WebApi.Domain;

namespace RunIt.WebApi.Application.Model;
public interface IGameService
{
    public ValueTask DecreaseRate();
    public IEnumerable<Game> Get();
    IEnumerable<Game> GetByName(string name);
    public ValueTask IncreaseRate();
     public Task<IEnumerable<Game>> GetCompanies();
}