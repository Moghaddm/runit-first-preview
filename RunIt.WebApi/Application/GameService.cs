using RunIt.WebApi.Application.Models;
using RunIt.WebApi.Domain;
using RunIt.WebApi.Domain.IRepositories;
using RunIt.WebApi.Infrastructure.Repositories;

namespace RunIt.WebApi.Application;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;

    public GameService(IGameRepository gameRepo)
    {
        _gameRepository = gameRepo;
    }

    public async ValueTask DecreaseRate(int productId) =>
        await _gameRepository.DecreaseRate(productId);

    public async ValueTask<IEnumerable<GameAddEditShowDTO>> Get() =>
        _gameRepository
            .Get()
            .Result.Select(
                game =>
                    new GameAddEditShowDTO
                    {
                        Title = game.Title,
                        Image = game.Image,
                        Rate = game.Rate
                    }
            )
            .ToList();

    public async ValueTask<GameAddEditShowDTO> GetById(int productId)
    {
        var game = await _gameRepository.GetById(productId);
        return new GameAddEditShowDTO()
        {
            Title = game.Title,
            Image = game.Image,
            Rate = game.Rate
        };
    }

    public async ValueTask<IEnumerable<GameAddEditShowDTO>> GetByName(string fullName) =>
        _gameRepository
            .GetByName(fullName)
            .Result.Select(
                game =>
                    new GameAddEditShowDTO
                    {
                        Title = game.Title,
                        Image = game.Image,
                        Rate = game.Rate
                    }
            )
            .ToList();

    public async ValueTask IncreaseRate(int productId) =>
        await _gameRepository.IncreaseRate(productId);
}
