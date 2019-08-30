namespace Db4o.Tutorial.Core.F1.Chapter5
{
    public class Pilot
    {
        string _name;
        int _points;
        
        public Pilot(string name, int points)
        {
            this._name = name;
            this._points = points;
        }
        
        public int Points
        {
            get
            {
                return this._points;
            }
        }
        
        public void AddPoints(int points)
        {
            this._points += points;
        }
        
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        
        override public string ToString()
        {
            return string.Format("{0}/{1}", this._name, this._points);
        }
    }
}