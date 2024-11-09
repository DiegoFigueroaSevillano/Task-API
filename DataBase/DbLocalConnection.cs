using System.Data.Common;

namespace Task_Project.DataBase;

public class DbLocalConnection : IDbConnection<List<Domain.Task>>
{
    public async Task<List<Domain.Task>> CreateConnectionAsync()
    {
        return AuxDB.Tasks;
    }
}