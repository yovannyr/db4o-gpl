/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using System;
using Db4o.Foundation;

namespace Db4o.Foundation
{
	public class SubTypePredicate : IPredicate4
	{
		private readonly Type _class;

		public SubTypePredicate(Type clazz)
		{
			_class = clazz;
		}

		public virtual bool Match(object candidate)
		{
			return _class.IsInstanceOfType(candidate);
		}
	}
}
