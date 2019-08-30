namespace Db4o.Tutorial.Core.F1.Chapter7
{
  using System.Globalization;

  /// <summary>
    /// A CultureInfo aware list of objects.
    /// CultureInfo objects hold a native pointer to 
    /// a system structure.
    /// </summary>
    public class LocalizedItemList
    {
        CultureInfo _culture;
        string[] _items;

        public LocalizedItemList(CultureInfo culture, string[] items)
        {
            this._culture = culture;
            this._items = items;
        }

        override public string ToString()
        {
            return string.Join(string.Concat(this._culture.TextInfo.ListSeparator,  " "), this._items);
        }
    }
}