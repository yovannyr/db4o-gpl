/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using System;
using Db4o.Internal;
using Db4o.Internal.Marshall;
using Db4o.Marshall;

namespace Db4o.Internal.Marshall
{
	public class ObjectReferenceContext : ObjectHeaderContext, IObjectIdContext
	{
		protected readonly Db4o.Internal.ObjectReference _reference;

		public ObjectReferenceContext(Transaction transaction, IReadBuffer buffer, ObjectHeader
			 objectHeader, Db4o.Internal.ObjectReference reference) : base(transaction
			, buffer, objectHeader)
		{
			_reference = reference;
		}

		public virtual int ObjectId()
		{
			return _reference.GetID();
		}

		public override Db4o.Internal.ClassMetadata ClassMetadata()
		{
			Db4o.Internal.ClassMetadata classMetadata = _reference.ClassMetadata();
			if (classMetadata == null)
			{
				throw new InvalidOperationException();
			}
			return classMetadata;
		}

		public virtual Db4o.Internal.ObjectReference ObjectReference()
		{
			return _reference;
		}

		protected virtual Db4o.Internal.ByteArrayBuffer ByteArrayBuffer()
		{
			return (Db4o.Internal.ByteArrayBuffer)Buffer();
		}
	}
}
