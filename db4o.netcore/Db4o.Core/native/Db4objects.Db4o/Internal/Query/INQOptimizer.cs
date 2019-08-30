using System.Reflection;
using Db4o.Query;

namespace Db4o.Internal.Query
{
	public interface INQOptimizer
	{
		void Optimize(IQuery q, object predicate, MethodBase method);
	}
}
