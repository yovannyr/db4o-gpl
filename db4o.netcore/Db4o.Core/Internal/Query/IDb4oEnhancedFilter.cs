/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Query;

namespace Db4o.Internal.Query
{
	/// <summary>FIXME: Rename to Db4oEnhancedPredicate</summary>
	public interface IDb4oEnhancedFilter
	{
		void OptimizeQuery(IQuery query);
	}
}
