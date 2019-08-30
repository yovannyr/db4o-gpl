/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.CS.Internal;
using Db4o.Internal.Events;

namespace Db4o.CS.Internal.Events
{
  using System;

  using Db4o.Events;

  public partial class ClientEventRegistryImpl : EventRegistryImpl
	{
		private readonly ClientObjectContainer _container;

		public ClientEventRegistryImpl(ClientObjectContainer container)
		{
			_container = container;
		}

		protected override void OnCommittedListenerAdded()
		{
			_container.OnCommittedListenerAdded();
		}

    public override event System.EventHandler<ObjectInfoEventArgs> Deleted
    {
      add
      {
        throw new ArgumentException("delete() event is raised only at server side.");
      }

      remove
      {
        throw new ArgumentException("delete() event is raised only at server side.");
      }
    }

    public override event System.EventHandler<CancellableObjectEventArgs> Deleting
    {
      add
      {
        throw new ArgumentException("deleting() event is raised only at server side.");
      }

      remove
      {
        throw new ArgumentException("deleting() event is raised only at server side.");
      }
    }
  }
}
