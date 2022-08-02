using System.Data;

namespace Worsoon.ESql.Apis;

public interface IInsertor<T>: IQuerier<T>
{
    public IInsertor<T> Add(T entity);
    public IInsertor<T> AddRange(List<T> list);
    public IInsertor<T> AddTable(DataTable table);
    public IInsertor<T> Set(string pattern, object? o);
   
    public int ExecuteIndentity();
    public Task<int> ExecuteIndentityAsync();
}