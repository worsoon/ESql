using System.Data;

namespace Worsoon.ESql.Apis;

public interface IDeletor<T>:IQuerier<T>
{
    public IDeletor<T> Where(string pattern);
    public IDeletor<T> Set(string pattern, object o);
}