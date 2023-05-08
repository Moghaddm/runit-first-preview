using Dapper;
using RunIt.WebApi.Domain;
using RunIt.WebApi.Domain.IRepositories;

namespace RunIt.WebApi.Infrastructure.Repositories;

public class GameRepository : IGameRepository
{
    private readonly DapperContext _context;

    public GameRepository(DapperContext context) => _context = context;

    public ValueTask DecreaseRate()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Game> Get()
    {
         try
        {
           var query = "SELECT * FROM GAMES";

        using (var connection = _context.CreateConnection())
        {
            var games = connection.Query<IEnumerable<Game>>(query);
            return games;
        }
        }
        catch (System.Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public async IEnumerable<Game> GetByName(string name)
    {
          try
        {
           var query = "SELECT * FROM GAME WHERE";

        using (var connection = _context.CreateConnection())
        {
            var games = await connection.QueryAsync<IEnumerable<Game>>(query);
            return games;
        }
        }
        catch (System.Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public ValueTask IncreaseRate()
    {
        throw new NotImplementedException();
    }
    public async Task<IEnumerable<Game>> GetCompanies()
{
   
}
}
