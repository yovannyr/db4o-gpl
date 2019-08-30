/* Copyright (C) 2009  Versant Inc.  http://www.db4o.com */
using System;
using Db4o.Foundation;
using Db4o.Internal;

namespace Db4o.native.Db4o.Typehandlers
{
	sealed internal class ComparablePreparedComparison<T> : IPreparedComparison where T : IComparable
	{
		public ComparablePreparedComparison(object source)
		{
			if (source is TransactionContext)
			{
				source = ((TransactionContext)source)._object;
			}

			_source = (IComparable)source;
		}

		public int CompareTo(object obj)
		{
			return _source.CompareTo(obj);
		}

		private readonly IComparable _source;
	}
}
