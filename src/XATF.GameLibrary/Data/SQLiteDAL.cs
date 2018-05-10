using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Data.Objects;

namespace XATF.GameLibrary.Data
{
    public class SQLiteDAL : BaseDAL
    {
        public SQLiteDAL()
        {
            var tables = Assembly.GetAssembly(typeof(BaseDO)).GetTypes()
                .Where(a => a.BaseType == typeof(BaseDO) && !a.IsAbstract)
                .Select(b => (BaseDO)Activator.CreateInstance(b)).ToList();

            if (!tables.Any())
            {
                return;
            }

            using (var db = new SQLite.SQLiteConnection(Constants.FILENAME_SQLITE))
            {
                foreach (var table in tables)
                {
                    db.CreateTable(table.GetType());
                }
            }
        }
        public override List<T> GetAll<T>(Expression<Func<T, bool>> expression = null)
        {
            using (var db = new SQLite.SQLiteConnection(Constants.FILENAME_SQLITE))
            {
                return expression == null ? db.Table<T>().ToList(): db.Table<T>().Where(expression).ToList();
            }
        }

        public override T GetOne<T>(Expression<Func<T, bool>> expression = null)
        {
            using (var db = new SQLite.SQLiteConnection(Constants.FILENAME_SQLITE))
            {
                return expression == null ? db.Table<T>().FirstOrDefault() : db.Table<T>().FirstOrDefault(expression);
            }
        }
    }
}