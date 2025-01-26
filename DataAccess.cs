using System.Collections;
using System.Data;
using Microsoft.Data.SqlClient;
using SmartSpExecutor;

public class DataAccess(ISpExecutor spExecutor)
{
    private readonly ISpExecutor _spExecutor = spExecutor;
    public async Task<User> GetUserAsync(string emailAddress)
    {
        var parameters = new Dictionary<string, SqlParameter>
        {
            { "@emailAddress", new SqlParameter("@emailAddress", SqlDbType.NVarChar) { Value = emailAddress} },
        };
        return await _spExecutor.ExecuteSpReturnTypeAsync<User>("YourDB.dbo.SpName", parameters);
    }

    public async Task<IEnumerable> GetUsersAsync(string role)
    {
        var parameters = new Dictionary<string, SqlParameter>
        {
            { "@role", new SqlParameter("@role", SqlDbType.NVarChar) { Value = role} },
        };
        return await _spExecutor.ExecuteSpReturnTypeColAsync<User>("YourDB.dbo.SpName", parameters);
    }
}