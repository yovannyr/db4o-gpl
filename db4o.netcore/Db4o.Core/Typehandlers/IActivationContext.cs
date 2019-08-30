/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Internal;
using Db4o.Internal.Activation;
using Db4o.Marshall;
using Db4o.Typehandlers;

namespace Db4o.Typehandlers
{
	public interface IActivationContext : IContext
	{
		void CascadeActivationToTarget();

		void CascadeActivationToChild(object obj);

		ObjectContainerBase Container();

		object TargetObject();

		Db4o.Internal.ClassMetadata ClassMetadata();

		IActivationDepth Depth();

		IActivationContext ForObject(object newTargetObject);

		IActivationContext Descend();
	}
}
