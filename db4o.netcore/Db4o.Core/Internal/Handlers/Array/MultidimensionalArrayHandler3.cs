/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal.Handlers.Array;

namespace Db4o.Internal.Handlers.Array
{
	/// <exclude></exclude>
	public class MultidimensionalArrayHandler3 : MultidimensionalArrayHandler
	{
		protected override ArrayVersionHelper CreateVersionHelper()
		{
			return new ArrayVersionHelper3();
		}
	}
}
