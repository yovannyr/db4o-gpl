/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.CS.Internal;
using Db4o.CS.Internal.Messages;

namespace Db4o.CS.Internal.Messages
{
	/// <exclude></exclude>
	public class MSwitchToMainFile : Msg, IServerSideMessage
	{
		public virtual void ProcessAtServer()
		{
			IServerMessageDispatcher serverThread = ServerMessageDispatcher();
			serverThread.SwitchToMainFile();
		}
	}
}
