namespace Db4o.Tutorial.Core.F1.Chapter6
{
  using System;

  public class TemperatureSensorReadout : SensorReadout
    {
        double _temperature;

        public TemperatureSensorReadout(DateTime time, Car car, string description, double temperature)
            : base(time, car, description)
        {
            this._temperature = temperature;
        }
        
        public double Temperature
        {
            get
            {
                return this._temperature;
            }
        }
        
        override public string ToString()
        {
            return string.Concat(base.ToString(), " temp: ", this._temperature.ToString());
        }
    }
}
