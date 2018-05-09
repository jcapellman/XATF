using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Data.Objects;

using Aircraft = XATF.GameLibrary.Renderables.BaseObjects.Aircraft;

namespace XATF.GameLibrary.Data
{
    public class SQLiteDAL : BaseDAL
    {
        public SQLiteDAL()
        {
            using (var db = new SQLite.SQLiteConnection(Constants.FILENAME_SQLITE))
            {
                db.CreateTable<Aircraft>();
                db.CreateTable<HUD>();
                db.CreateTable<Level>();

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