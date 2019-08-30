namespace Db4o.Tutorial.Core.F1.Chapter5
{
  using Query;

  public class RetrieveAllSensorReadoutsPredicate : Predicate 
	{
		public bool Match(SensorReadout candidate)
		{
			return true;
		}
	}
}