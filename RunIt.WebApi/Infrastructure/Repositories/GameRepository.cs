using Dapper;
using RunIt.WebApi.Domain;
using RunIt.WebApi.Domain.IRepositories;

namespace RunIt.WebApi.Infrastructure.Repositories;

public class GameRepository : IGameRepository
{
    private readonly DapperContext _context;

    public GameRepository(DapperContext context) => _context = context;

    public async ValueTask DecreaseRate(int productId)
    {
        try
        {
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync("UPDATE GAMES SET RATE = RATE-1 WHERE ID = @ProductId", new { ProductId = productId });
            }
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public async ValueTask<IEnumerable<Game>> Get()
    {
        try
        {
            var query = "SELECT * FROM GAMES";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<Game>(query);
            }
        }
        catch (System.Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public async ValueTask<IEnumerable<Game>> GetByName(string fullName)
    {
        try
        {
            var query = "SELECT * FROM GAMES WHERE FULLNAME = @FullName";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<Game>(query, new { FullName = fullName });
            }
        }
        catch (System.Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }
    public async ValueTask<Game> GetById(int productId)
    {
        try
        {
            var query = "SELECT * FROM GAMES WHERE ID = @ProductId";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<Game>(query, new { ProductId = productId });
            }
        }
        catch (System.Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }
    public async ValueTask IncreaseRate(int productId)
    {
        try
        {
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync("UPDATE GAMES SET RATE = RATE+1 WHERE ID = @ProductId", new { ProductId = productId });
            }
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }
}

