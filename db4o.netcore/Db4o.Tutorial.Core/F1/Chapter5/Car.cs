namespace Db4o.Tutorial.Core.F1.Chapter5
{
  using System;
  using System.Collections;

  public class Car
    {
        string _model;
        Pilot _pilot;
        IList _history;
        
        public Car(string model)
        {
            this._model = model;
            this._pilot = null;
            this._history = new ArrayList();
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
        
        public SensorReadout[] GetHistory()
        {
            SensorReadout[] history = new SensorReadout[this._history.Count];
            this._history.CopyTo(history, 0);
            return history;
        }
        
        public void Snapshot()
        {
            this._history.Add(new TemperatureSensorReadout(DateTime.Now, this, "oil", this.PollOilTemperature()));
            this._history.Add(new TemperatureSensorReadout(DateTime.Now, this, "water", this.PollWaterTemperature()));
            this._history.Add(new PressureSensorReadout(DateTime.Now, this, "oil", this.PollOilPressure()));
        }
        
        protected double PollOilTemperature()
        {
            return 0.1*this._history.Count;
        }
        
        protected double PollWaterTemperature()
        {
            return 0.2*this._history.Count;
        }
        
        protected double PollOilPressure()
        {
            return 0.3*this._history.Count;
        }
        
        override public string ToString()
        {
			return string.Format("{0}[{1}]/{2}", this._model, this._pilot, this._history.Count);
        }
    }
}
