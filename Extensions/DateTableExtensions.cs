using System.Data;
using System.Reflection;
using Worsoon.Core;

namespace Worsoon.ESql;

public static class DateTableExtensions
{
    public static IEnumerable<T> ToEntities<T>(this DataTable? table) where T : class, new()
    { 
        var list = new List<T>();
        var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        
        if (table != null)
        {
            foreach (DataRow row in table.Rows)
            {
                T t = new();
                foreach (var prop in props)
                    try
                    {
                        prop.SetValue(t, row[prop.Name].ToType(prop.PropertyType));
                    }
                    catch
                    {
                        // ignored
                    }

                list.Add(t);
            }
        }

        return list;
    }
}