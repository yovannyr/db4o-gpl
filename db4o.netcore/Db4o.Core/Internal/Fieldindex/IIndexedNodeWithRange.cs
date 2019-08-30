/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal.Btree;
using Db4o.Internal.Fieldindex;

namespace Db4o.Internal.Fieldindex
{
	public interface IIndexedNodeWithRange : IIndexedNode
	{
		IBTreeRange GetRange();
	}
}
