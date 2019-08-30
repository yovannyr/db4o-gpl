/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.CS.Internal;
using Db4o.Foundation;
using Db4o.Internal;

namespace Db4o.CS.Internal
{
	/// <summary>Defines a strategy on how to prefetch objects from the server.</summary>
	/// <remarks>Defines a strategy on how to prefetch objects from the server.</remarks>
	public interface IPrefetchingStrategy
	{
		int PrefetchObjects(ClientObjectContainer container, Transaction trans, IIntIterator4
			 ids, object[] prefetched, int prefetchCount);
	}
}
