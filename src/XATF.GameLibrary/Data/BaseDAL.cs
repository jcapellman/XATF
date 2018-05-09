using System;
using System.Collections.Generic;

namespace XATF.GameLibrary.Data
{
    public abstract class BaseDAL
    {
        public abstract List<T> GetAll<T>(System.Linq.Expressions.Expression<Func<T, bool>> expression = null) where T : new();

        public abstract T GetOne<T>(System.Linq.Expressions.Expression<Func<T, bool>> expression = null) where T : new();
    }
}