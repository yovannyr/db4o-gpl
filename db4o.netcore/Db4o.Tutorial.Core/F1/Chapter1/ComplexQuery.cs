namespace Db4o.Tutorial.Core.F1.Chapter1
{
  using Query;

  public class ComplexQuery : Predicate
    {
    	public bool Match(Pilot pilot)
    	{
	    	return pilot.Points > 99
                && pilot.Points < 199
                || pilot.Name=="Rubens Barrichello";
    	}
    }
}
