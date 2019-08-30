namespace Db4o.Tutorial.Core.F1.Chapter5
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
            return string.Format("{0} temp: {1}", base.ToString(), this._temperature);
        }
    }
}
