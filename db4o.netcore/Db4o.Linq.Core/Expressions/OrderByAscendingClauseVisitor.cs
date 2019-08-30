/* Copyright (C) 2007 - 2008  Versant Inc.  http://www.db4o.com */

using System.Linq.Expressions;
using Db4o.Linq.Caching;
using Db4o.Linq.Internals;
using Db4o.Query;

namespace Db4o.Linq.Expressions
{
	internal class OrderByAscendingClauseVisitor : OrderByClauseVisitorBase
	{
		private static ICache4<Expression, IQueryBuilderRecord> _cache = ExpressionCacheFactory.NewInstance(10);

		protected override ICache4<Expression, IQueryBuilderRecord> GetCachingStrategy()
		{
			return _cache;
		}

		protected override void ApplyDirection(IQuery query)
		{
			query.OrderAscending();
		}
	}
}
