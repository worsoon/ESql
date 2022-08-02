using System.Data;

namespace Worsoon.ESql.Apis;

public interface ITypeQuerier
{
    public int ExecuteNoneQuery(string sql);
    public Task<int> ExecuteNoneQueryAsync(string sql);
    public int ExecuteNoneQuery(string sql, IDataParameter dataParameter);
    public Task<int> ExecuteNoneQueryAsync(string sql, IDataParameter dataParameter);
}