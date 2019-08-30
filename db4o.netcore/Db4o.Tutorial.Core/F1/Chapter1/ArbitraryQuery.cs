namespace Db4o.Tutorial.Core.F1.Chapter1
{
  using Query;

  public class ArbitraryQuery : Predicate
    {
    	private int[] _points;
    	
    	public ArbitraryQuery(int[] points)
    	{
    		this._points=points;
    	}
    
    	public bool Match(Pilot pilot)
    	{
        	foreach (int points in this._points)
        	{
        		if (pilot.Points == points)
        		{
        			return true;
        		}
        	}
        	return pilot.Name.StartsWith("Rubens");
    	}
    }
}
