/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Foundation;
using Db4o.Internal;
using Db4o.Internal.Query.Processor;
using Db4o.Query;

namespace Db4o.Internal.Query.Processor
{
	public interface IInternalCandidate : ICandidate
	{
		IInternalCandidate GetRoot();

		Db4o.Internal.ClassMetadata ClassMetadata();

		QCandidates Candidates();

		LocalTransaction Transaction();

		bool Evaluate(QConObject qConObject, QE evaluator);

		bool FieldIsAvailable();

		int Id();

		IPreparedComparison PrepareComparison(ObjectContainerBase container, object constraint
			);

		bool Evaluate(QPending pending);

		void DoNotInclude();

		void Root(IInternalCandidate root);

		bool Include();

		Tree PendingJoins();
	}
}
