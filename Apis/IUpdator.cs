using System.Data;

namespace Worsoon.ESql.Apis;

public interface IUpdator<T>: IQuerier<T>
{
    public IUpdator<T> Where(string pattern);
    public IUpdator<T> Set(string pattern, object o);
    [Obsolete(message:"尚未实现的方法")]
    public IUpdator<T> Add(T entity);
    [Obsolete(message:"尚未实现的方法")]
    public IUpdator<T> AddRange(IEnumerable<T> list);
}