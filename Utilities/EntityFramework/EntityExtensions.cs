using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public static class EntityExtensions
    {
        public static bool Exists<TContext, TEntity>(this TContext context, TEntity pEntity)
        where TContext : DbContext
        where TEntity : class
        {
            var testLocal = context.Set<TEntity>().Local.FirstOrDefault(pTEntity => pTEntity == pEntity);

            return context.Set<TEntity>().Local.Any(pTEntity => pTEntity == pEntity);
        }
    }
}
