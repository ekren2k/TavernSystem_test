using Microsoft.Data.SqlClient;

namespace TavernSystem.Repositories;

public interface IAdventurersRepository
{



    public async Task<object> getAllAdventurers();
}