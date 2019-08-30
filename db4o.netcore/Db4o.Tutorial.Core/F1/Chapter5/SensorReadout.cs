namespace Db4o.Tutorial.Core.F1.Chapter5
{
  using System;

  public class SensorReadout
    {
        DateTime _time;
        Car _car;
        string _description;
        
        public SensorReadout(DateTime time, Car car, string description)
        {
            this._time = time;
            this._car = car;
            this._description = description;
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
        
        public string Description
        {
            get
            {
                return this._description;
            }
        }
        
        override public string ToString()
        {
            return string.Format("{0}:{1}:{2}", this._car, this._time, this._description);
        }
    }
}
