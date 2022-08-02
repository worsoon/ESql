using System.Data;

namespace Worsoon.ESql.Apis;

public interface ISelector<T>:IQuerier<T>
{
    public object? ExecuteScalar();
    public Task<object?> ExecuteScalarAsync();
    public DataSet? ExecuteSet();
    public Task<DataSet?> ExecuteSetAsync();
    public T? ToEntity();
    public Task<T?> ToEntityAsync();
    public IEnumerable<T>? ToList();
    public Task<IEnumerable<T>?> ToListAsync();
    public ISelector<T> Where(string pattern);
    public ISelector<T> Set(string pattern,object o);
    public ISelector<T> Skip(int skip);
    public ISelector<T> Take(int skip);
    public int Count();
    public Task<int> CountAsync();
    public bool Any();
    public Task<bool> AnyAsync();
}