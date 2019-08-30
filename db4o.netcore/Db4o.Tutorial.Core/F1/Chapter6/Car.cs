namespace Db4o.Tutorial.Core.F1.Chapter6
{
  using System;

  public class Car
    {
        string _model;
        Pilot _pilot;
        SensorReadout _history;
        
        public Car(string model)
        {
            this._model = model;
            this._pilot = null;
            this._history = null;
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
        
        public SensorReadout GetHistory()
        {
            return this._history;
        }
        
        public void Snapshot()
        {        
            this.AppendToHistory(new TemperatureSensorReadout(
                DateTime.Now, this, "oil", this.PollOilTemperature()));
            this.AppendToHistory(new TemperatureSensorReadout(
                DateTime.Now, this, "water", this.PollWaterTemperature()));
            this.AppendToHistory(new PressureSensorReadout(
                DateTime.Now, this, "oil", this.PollOilPressure()));
        }

        protected double PollOilTemperature()
        {
            return 0.1*this.CountHistoryElements();
        }
        
        protected double PollWaterTemperature()
        {
            return 0.2*this.CountHistoryElements();
        }
        
        protected double PollOilPressure()
        {
            return 0.3*this.CountHistoryElements();
        }
        
        override public string ToString()
        {
			return string.Format("{0}[{1}]/{2}", this._model, this._pilot, this.CountHistoryElements());
        }
        
        private int CountHistoryElements()
        {
            return (this._history == null ? 0 : this._history.CountElements());
        }
        
        private void AppendToHistory(SensorReadout readout)
        {
            if (this._history == null)
            {
                this._history = readout;
            }
            else
            {
                this._history.Append(readout);
            }
        }
    }
}
