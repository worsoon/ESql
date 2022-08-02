using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worsoon.ESql
{
    [Flags]
    public enum DbTypes
    {
        MySQL = 2 << 1,
        SQLite = 2 << 2,
        MSSQL = 2 << 3,
    }
}
