namespace Db4o.Tutorial.Core.F1.Chapter7
{
  using System;
  using System.IO;

  using Chapter4;

  using Db4o;

  using Query;

  public class EvaluationExample : Util
	{
        readonly static string YapFileName = Path.Combine(
                               Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                               "formula1.yap");  
		public static void Main(string[] args)
		{ 
			File.Delete(YapFileName);
            using(IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
			{
				StoreCars(db);
				QueryWithEvaluation(db);
			}
		}

		public static void StoreCars(IObjectContainer db)
		{
			Pilot pilot1 = new Pilot("Michael Schumacher", 100);
			Car car1 = new Car("Ferrari");
			car1.Pilot = pilot1;
			car1.Snapshot();
			db.Store(car1);
			Pilot pilot2 = new Pilot("Rubens Barrichello", 99);
			Car car2 = new Car("BMW");
			car2.Pilot = pilot2;
			car2.Snapshot();
			car2.Snapshot();
			db.Store(car2);
		}

		public static void QueryWithEvaluation(IObjectContainer db)
		{
			IQuery query = db.Query();
			query.Constrain(typeof (Car));
			query.Constrain(new EvenHistoryEvaluation());
			IObjectSet result = query.Execute();
			Util.ListResult(result);
		}
	}
}