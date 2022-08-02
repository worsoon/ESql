using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worsoon.ESql.Apis
{
    public interface IQuerier<T>
    {
        public string ToSql();
        public int ExecuteNoneQuery();
        public Task<int> ExecuteNoneQueryAsync();
    }
}
