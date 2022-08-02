using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worsoon.ESql
{
    internal static class DbExtension
    {
        public static DbType ToDbType(this Type type)
        {
            // 写入数据类型
            var code = Type.GetTypeCode(type);
            switch (code)
            {
                case TypeCode.Boolean:
                    return DbType.Boolean;
                case TypeCode.Char:
                case TypeCode.SByte:
                case TypeCode.Byte:
                    return DbType.Byte;
                case TypeCode.Int16:
                case TypeCode.UInt16:
                    return DbType.Int16;
                case TypeCode.Int32:
                case TypeCode.UInt32:
                    return DbType.Int32;
                case TypeCode.Int64:
                case TypeCode.UInt64:
                    return DbType.Int64;
                case TypeCode.Single:
                    return DbType.Double;
                case TypeCode.Double:
                    return DbType.Double;
                case TypeCode.Decimal:
                    return DbType.Decimal;
                case TypeCode.DateTime:
                    return DbType.DateTime;
                case TypeCode.String:
                    return DbType.String;
                default:
                    return DbType.Object;
            }
        }
    }
}
