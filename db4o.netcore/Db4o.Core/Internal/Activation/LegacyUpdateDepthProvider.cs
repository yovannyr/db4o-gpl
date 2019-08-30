/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal.Activation;

namespace Db4o.Internal.Activation
{
	public class LegacyUpdateDepthProvider : IUpdateDepthProvider
	{
		public virtual FixedUpdateDepth ForDepth(int depth)
		{
			return new LegacyFixedUpdateDepth(depth);
		}

		public virtual UnspecifiedUpdateDepth Unspecified(IModifiedObjectQuery query)
		{
			return LegacyUnspecifiedUpdateDepth.Instance;
		}
	}
}
