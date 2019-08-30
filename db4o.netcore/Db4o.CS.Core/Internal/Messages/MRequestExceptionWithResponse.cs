/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using System;
using Db4o.CS.Internal.Messages;
using Db4o.Internal;

namespace Db4o.CS.Internal.Messages
{
	public class MRequestExceptionWithResponse : MsgD, IMessageWithResponse
	{
		public virtual Msg ReplyFromServer()
		{
			Platform4.ThrowUncheckedException((Exception)ReadSingleObject());
			return null;
		}
	}
}
