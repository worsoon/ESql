

using System.Linq.Expressions;

namespace Worsoon.ESql.Apis;

public interface IFinder<T>
{
    public T? Find(Func<T, bool> expression, bool autoBind = false);
    public IEnumerable<T>? Finds(Func<T, bool> expression, bool autoBind = false);
    public Task<T?> FindAsync(Func<T, bool> expression, bool autoBind = false);
    public Task<IEnumerable<T>?> FindsAsync(Func<T, bool> expression, bool autoBind = false);
    public bool Any(Func<T, bool> expression);
    public Task<bool> AnyAsync(Func<T, bool> expression);
    public int Count(Func<T, bool> expression);
    public Task<int> CountAsync(Func<T, bool> expression);
    public void Update();
    public Task UpdateAsync();
}