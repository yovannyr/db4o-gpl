/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal;
using Db4o.Internal.References;

namespace Db4o.Internal.References
{
	/// <exclude></exclude>
	public interface IReferenceSystemFactory
	{
		IReferenceSystem NewReferenceSystem(IInternalObjectContainer container);
	}
}
