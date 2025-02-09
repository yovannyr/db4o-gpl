/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Foundation;
using Db4o.Typehandlers;

namespace Db4o.Internal
{
	/// <exclude></exclude>
	public interface IVersionedTypeHandler : ITypeHandler4, IDeepClone
	{
		ITypeHandler4 UnversionedTemplate();
	}
}
