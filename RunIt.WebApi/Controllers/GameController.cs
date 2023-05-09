using Microsoft.AspNetCore.Mvc;
using RunIt.WebApi.Application;
using RunIt.WebApi.Application.Models;

namespace RunIt.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]", Name = nameof(GameController))]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameservice) => _gameService = gameservice;

    [HttpGet(Name = nameof(Get))]
    public async ValueTask<IActionResult> Get() => Ok(await _gameService.Get());

    [HttpGet(Name = nameof(GetByName))]
    public async ValueTask<IActionResult> GetByName(string fullName)
    {
        if (String.IsNullOrEmpty(fullName))
            return BadRequest("Send Name of Game !");
        return Ok(await _gameService.GetByName(fullName));
    }

    public async ValueTask<IActionResult> GetById(int id)
    {
        var game = await _gameService.GetById(id);
        if (game is not null)
            return Ok(game);
        return NotFound("Product Does Not Exist!");
    }

    [HttpPatch("[action]", Name = nameof(DecreaseRate))]
    public async ValueTask<IActionResult> DecreaseRate(int productId)
    {
        if (await _gameService.GetById(productId) is not null)
            Ok(_gameService.DecreaseRate(productId));
        return BadRequest("Send Product ID !");
    }

    public async ValueTask<IActionResult> IncreaseRate(int productId)
    {
        if (await _gameService.GetById(productId) is not null)
            Ok(_gameService.IncreaseRate(productId));
        return BadRequest("Send Product ID !");
    }
}
