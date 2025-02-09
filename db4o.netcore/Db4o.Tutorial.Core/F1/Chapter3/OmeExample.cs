namespace Db4o.Tutorial.Core.F1.Chapter3
{
  using System;
  using System.IO;

  using Db4o;

  public class OMEExample : Util
    {
        readonly static string YapFileName = Path.Combine(
                               Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                               "ome.db4o");

        public static void Main(string[] args)
        {
            File.Delete(YapFileName);
            StorePilots();
        }

        public static void StorePilots()
        {
            using(IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
            {
                Pilot pilot1 = new Pilot("Michael Schumacher", 100);
                db.Store(pilot1);
                Console.WriteLine("Stored {0}", pilot1);
                Pilot pilot2 = new Pilot("Rubens Barrichello", 99);
                db.Store(pilot2);
                Console.WriteLine("Stored {0}", pilot2);
            }
        }

    }
}
