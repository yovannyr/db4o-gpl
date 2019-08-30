namespace Db4o.Tutorial.Core.F1.Chapter4
{
  using System;
  using System.Collections;

  public class Car
    {
        string _model;
        Pilot _pilot;
        IList _history;
        
        public Car(string model) : this(model, new ArrayList())
        {
        }
        
        public Car(string model, IList history)
        {
            this._model = model;
            this._pilot = null;
            this._history = history;
        }
        
        public Pilot Pilot
        {
            get
            {
                return this._pilot;
            }
            
            set
            {
                this._pilot = value;
            }
        }
        
        public string Model
        {
            get
            {
                return this._model;
            }
        }
        
        public IList History
        {
        	get
        	{
	            return this._history;
	        }
        }
        
        public void Snapshot()
        {
            this._history.Add(new SensorReadout(this.Poll(), DateTime.Now, this));
        }
        
        protected double[] Poll()
        {
            int factor = this._history.Count + 1;
            return new double[] { 0.1d*factor, 0.2d*factor, 0.3d*factor };
        }
        
        override public string ToString()
        {
			return string.Format("{0}[{1}]/{2}", this._model, this._pilot, this._history.Count);
        }
    }
}
