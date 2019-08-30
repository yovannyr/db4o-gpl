/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Activation;
using Db4o.Internal;

namespace Db4o.TA
{
	/// <summary>
	/// An
	/// <see cref="Db4o.Activation.IActivator">Db4o.Activation.IActivator
	/// 	</see>
	/// implementation that activates an object on a specific
	/// transaction.
	/// </summary>
	/// <exclude></exclude>
	internal sealed class TransactionalActivator : IActivator
	{
		private readonly Transaction _transaction;

		private readonly ObjectReference _objectReference;

		public TransactionalActivator(Transaction transaction, ObjectReference objectReference
			)
		{
			_objectReference = objectReference;
			_transaction = transaction;
		}

		public void Activate(ActivationPurpose purpose)
		{
			_objectReference.ActivateOn(_transaction, purpose);
		}
	}
}
