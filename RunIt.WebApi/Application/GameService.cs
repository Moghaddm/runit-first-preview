using RunIt.WebApi.Domain;
using RunIt.WebApi.Domain.IRepositories;
using RunIt.WebApi.Infrastructure.Repositories;

namespace RunIt.WebApi.Application;

public class GameService : Model.IGameService
{
    private readonly GameRepository  _GameRepository;
    public GameService(GameRepository gameRepo)
    {
        _GameRepository=gameRepo;
    }
    public ValueTask DecreaseRate()
    {
        throw new NotImplementedException();
    }

    public  IEnumerable<Game> Get()
    {
        return  _GameRepository.Get();
    }

    public  IEnumerable<Game> GetByName(string name)
    {
        return _GameRepository.GetByName(name);
    }

    public async Task<IEnumerable<Game>> GetCompanies()
    {
      return await  _GameRepository.GetCompanies();
    }

    public  ValueTask IncreaseRate()
    {
        return  _GameRepository.IncreaseRate();
    }
}