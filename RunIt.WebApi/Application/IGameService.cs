using RunIt.WebApi.Application.Models;
using RunIt.WebApi.Domain;

namespace RunIt.WebApi.Application
{
    public interface IGameService
    {
        ValueTask<IEnumerable<GameAddEditShowDTO>> Get();
        ValueTask<IEnumerable<GameAddEditShowDTO>> GetByName(string fullName);
        ValueTask IncreaseRate(int productId);
        ValueTask DecreaseRate(int productId);
    }
}
