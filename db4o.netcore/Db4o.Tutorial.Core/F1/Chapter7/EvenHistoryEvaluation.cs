namespace Db4o.Tutorial.Core.F1.Chapter7
{
  using Chapter4;

  using Query;

  public class EvenHistoryEvaluation : IEvaluation
	{
		public void Evaluate(ICandidate candidate)
		{
			Car car=(Car)candidate.GetObject();
			candidate.Include(car.History.Count % 2 == 0);
		}
	}
}