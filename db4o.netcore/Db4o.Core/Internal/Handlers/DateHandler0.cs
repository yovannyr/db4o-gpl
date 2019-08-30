/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using System;
using Db4o.Internal.Handlers;
using Db4o.Marshall;

namespace Db4o.Internal.Handlers
{
	/// <exclude></exclude>
	public class DateHandler0 : DateHandler
	{
		public override object Read(IReadContext context)
		{
			long value = context.ReadLong();
			if (value == long.MaxValue)
			{
				return PrimitiveNull();
			}
			return new DateTime(value);
		}
	}
}
