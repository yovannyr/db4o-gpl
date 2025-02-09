/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Reflect;
using Db4o.Typehandlers;

namespace Db4o.Internal
{
	/// <exclude></exclude>
	public interface IBuiltinTypeHandler : ITypeHandler4
	{
		void RegisterReflector(IReflector reflector);

		IReflectClass ClassReflector();
	}
}
