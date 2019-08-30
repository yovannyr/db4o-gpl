/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal;
using Db4o.Internal.Marshall;

namespace Db4o.Internal
{
	/// <exclude></exclude>
	public interface IReadsObjectIds
	{
		ObjectID ReadObjectID(IInternalReadContext context);
	}
}
