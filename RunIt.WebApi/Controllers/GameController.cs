using Microsoft.AspNetCore.Mvc;
using RunIt.WebApi.Application;
using RunIt.WebApi.Application.Model;

namespace RunIt.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]",Name = nameof(GameController))]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;
   public GameController(GameService Gameservice)
   {
   _gameService=Gameservice;
   }
    [HttpGet("[action]", Name = nameof(Get))]
    public async ValueTask<IActionResult> Get() => Ok(_gameService.Get());



    [HttpGet("[action]/{Name}", Name = nameof(GetByName))]
    public async ValueTask<IActionResult> GetByName(string Name)
    {
        return  Ok(_gameService.GetByName(Name));
    }


    [HttpGet("[action]", Name = nameof(DecreaseRate))]
    public async ValueTask<IActionResult> DecreaseRate() => Ok(_gameService.DecreaseRate());



    [HttpGet("[action]", Name = nameof(GetCompanies))]
    public async ValueTask<IActionResult> GetCompanies() => Ok(_gameService.GetCompanies);



    [HttpGet("[action]", Name = nameof(IncreaseRate))]
    public async ValueTask<IActionResult> IncreaseRate() => Ok(_gameService.IncreaseRate());
}
