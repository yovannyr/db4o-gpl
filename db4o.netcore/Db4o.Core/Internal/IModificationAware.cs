/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

namespace Db4o.Internal
{
	/// <exclude></exclude>
	public interface IModificationAware
	{
		bool IsModified(object obj);
	}
}
