using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace RunIt.WebApi.Infrastructure;

public class DapperContext 
{
    private readonly IConfiguration _configuration;
    public DapperContext(IConfiguration configuration) => _configuration = configuration;
    public IDbConnection CreateConnection() => new SqlConnection(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("SQLServer"));
    public async Task Initial()
    {
        using var connection=CreateConnection();
        await _initGames();
        async Task _initGames()
        {
            var sqlScriptsFolderPath= Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"SQLScripts\GameTable.sql");

            var createTables = 
        await connection.ExecuteAsync(Directory.GetFiles(sqlScriptsFolderPath).FirstOrDefault());
        }
    }
}