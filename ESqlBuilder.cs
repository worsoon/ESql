using System.Reflection;
using Worsoon.Core;

namespace Worsoon.ESql
{
    public class ESqlBuilder
    {
        private string _dll = string.Empty;
        private string _instance = string.Empty;
        public bool TableSync { get; private set; }
        public DbTypes Type { get; private set; }
        public string? ConnectString { get; private set; }
        public bool? SqlPrinter { get; private set; }
        public ICacheService? CacheService { get; set; } = new CacheServerBuilder().Build();

        public ESqlBuilder()
        {
        }

        public ESqlBuilder UseCache(ICacheService cacheService)
        {
            CacheService = cacheService;
            return this;
        }

        public ESqlBuilder UseTableSync(bool sync)
        {
            TableSync = sync;
            return this;
        }

        public ESqlBuilder UseSqlPrinter(bool print)
        {
            SqlPrinter = print;
            return this;
        }

        public ESqlBuilder UseString(DbTypes type, string connectString)
        {
            Type = type;
            ConnectString = connectString;

            switch (Type)
            {
                case DbTypes.MySQL:
                {
                    _dll = "{0}/ESql.Drivers.MySqlDriver.dll".Format(AppDomain.CurrentDomain.BaseDirectory);
                    _instance = "ESql.Drivers.MySqlDriver.ESqlMySqlBuilder";
                }
                    break;
                case DbTypes.SQLite:
                {
                    _dll = "{0}/ESql.Drivers.SqliteDriver.dll".Format(AppDomain.CurrentDomain.BaseDirectory);
                    _instance = "ESql.Drivers.SqliteDriver.ESqlSqliteBuilder";
                }
                    break;
            }

            return this;
        }

        public IESql? Build()
        {
            if (ConnectString != null)
            {
                var instance = Activator.CreateInstanceFrom(_dll, _instance, true, BindingFlags.Default, null,
                    new object[]
                    {
                        ConnectString, TableSync, SqlPrinter ?? false, CacheService ?? (new CacheServerBuilder
                            ().Build())
                    }, null,
                    null);

                IESql? sql = null;
                if (instance != null)
                    sql = (IESql)instance.Unwrap()!;

                if (sql == null)
                {
                    AssertX.Fatal("注入驱动失败！");
                }

                return sql;
            }

            return null;
        }
    }
}