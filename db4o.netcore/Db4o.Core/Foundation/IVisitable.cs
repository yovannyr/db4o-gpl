/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Foundation;

namespace Db4o.Foundation
{
	/// <exclude></exclude>
	public interface IVisitable
	{
		void Accept(IVisitor4 visitor);
	}
}
