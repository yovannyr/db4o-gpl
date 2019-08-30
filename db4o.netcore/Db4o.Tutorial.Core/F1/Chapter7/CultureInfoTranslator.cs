namespace Db4o.Tutorial.Core.F1.Chapter7
{
  using System;
  using System.Globalization;

  using Config;

  using Db4o;

  public class CultureInfoTranslator : IObjectConstructor
    {
        public object OnStore(IObjectContainer container, object applicationObject)
        {
            System.Console.WriteLine("onStore for {0}", applicationObject);
            return ((CultureInfo)applicationObject).Name;
        }
        
        public object OnInstantiate(IObjectContainer container, object storedObject)
        {
            System.Console.WriteLine("onInstantiate for {0}", storedObject);
            string name = (string)storedObject;
            return CultureInfo.CreateSpecificCulture(name);
        }
        
        public void OnActivate(IObjectContainer container, object applicationObject, object storedObject)
        {
            System.Console.WriteLine("onActivate for {0}/{1}", applicationObject, storedObject);
        }
        
        public Type StoredClass()
        {
            return typeof(string);
        }
    }
}