/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

namespace Db4o.Internal.Activation
{
	public interface IModifiedObjectQuery
	{
		bool IsModified(object obj);
	}
}
