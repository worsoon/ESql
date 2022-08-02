using Worsoon.ESql.Apis;

namespace Worsoon.ESql;
public interface IESql
{
    public ISelector<T> Select<T>(string expression="*") where T : class, new();
    public IDeletor<T> Delete<T>() where T : class, new();
    public IUpdator<T> Update<T>(string statement = "") where T : class, new();
    public IInsertor<T> Insert<T>(string statement = "") where T : class, new();
    public IQuerier<T> Query<T>(string statement = "") where T : class, new();
    public IFinder<T> Find<T>() where T : class, new();
    public IStructor<T> Struct<T>() where T : class, new();
    public IQuerier<T> Querier<T>() where T : class, new();
    public ITypeQuerier TypeQuerier(Type type);
}