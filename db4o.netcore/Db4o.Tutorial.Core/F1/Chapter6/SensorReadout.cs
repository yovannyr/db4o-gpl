namespace Db4o.Tutorial.Core.F1.Chapter6
{
  using System;

  public abstract class SensorReadout
    {
        DateTime _time;
        Car _car;
        string _description;
        SensorReadout _next;
        
        protected SensorReadout(DateTime time, Car car, string description)
        {
            this._time = time;
            this._car = car;
            this._description = description;
            this._next = null;            
        }
        
        public Car Car
        {
            get
            {
                return this._car;
            }
        }
        
        public DateTime Time
        {
            get
            {
                return this._time;
            }
        }
        
        public SensorReadout Next
        {
            get
            {
                return this._next;
            }
        }
        
        public void Append(SensorReadout sensorReadout)
        {
            if (this._next == null)
            {
                this._next = sensorReadout;
            }
            else
            {
                this._next.Append(sensorReadout);
            }
        }
        
        public int CountElements()
        {
            return (this._next == null ? 1 : this._next.CountElements() + 1);
        }
        
        override public string ToString()
        {
            return string.Format("{0} : {1} : {2}", this._car, this._time, this._description);
        }
    }
}
