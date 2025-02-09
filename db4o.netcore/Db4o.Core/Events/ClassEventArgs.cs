/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using System;

namespace Db4o.Events
{
	public class ClassEventArgs : EventArgs
	{
		private Db4o.Internal.ClassMetadata _clazz;

		public ClassEventArgs(Db4o.Internal.ClassMetadata clazz)
		{
			_clazz = clazz;
		}

		public virtual Db4o.Internal.ClassMetadata ClassMetadata()
		{
			return _clazz;
		}
	}
}
