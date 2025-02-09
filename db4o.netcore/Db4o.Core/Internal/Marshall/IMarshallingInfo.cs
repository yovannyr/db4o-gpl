/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal.Marshall;
using Db4o.Marshall;

namespace Db4o.Internal.Marshall
{
	/// <exclude></exclude>
	public interface IMarshallingInfo : IAspectVersionContext
	{
		Db4o.Internal.ClassMetadata ClassMetadata();

		IReadBuffer Buffer();

		void BeginSlot();

		bool IsNull(int fieldIndex);
	}
}
