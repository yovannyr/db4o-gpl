/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal.Activation;

namespace Db4o.Internal.Activation
{
	public interface IUpdateDepthProvider
	{
		UnspecifiedUpdateDepth Unspecified(IModifiedObjectQuery query);

		FixedUpdateDepth ForDepth(int depth);
	}
}
