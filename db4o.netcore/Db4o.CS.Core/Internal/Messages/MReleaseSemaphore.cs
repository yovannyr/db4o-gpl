/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.CS.Internal.Messages;

namespace Db4o.CS.Internal.Messages
{
	public sealed class MReleaseSemaphore : MsgD, IServerSideMessage
	{
		public void ProcessAtServer()
		{
			LocalContainer().ReleaseSemaphore(Transaction(), ReadString());
		}
	}
}
