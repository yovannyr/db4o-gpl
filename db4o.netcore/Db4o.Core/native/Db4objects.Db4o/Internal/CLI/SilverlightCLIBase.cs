/* Copyright (C) 2011 Versant Inc.   http://www.db4o.com */
#if SILVERLIGHT
using Db4o.IO;

namespace Db4o.Internal.CLI
{
	internal abstract class SilverlightCLIBase : CLIBase
	{
		public override IStorage NewStorage()
		{
			return new IsolatedStorageStorage();
		}
	}
}
#endif