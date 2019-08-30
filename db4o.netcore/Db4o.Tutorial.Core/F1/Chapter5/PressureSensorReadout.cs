namespace Db4o.Tutorial.Core.F1.Chapter5
{
  using System;

  public class PressureSensorReadout : SensorReadout
    {
        double _pressure;
        
        public PressureSensorReadout(DateTime time, Car car, string description, double pressure)
            : base(time, car, description)
        {
            this._pressure = pressure;
        }
        
        public double Pressure
        {
            get
            {
                return this._pressure;
            }
        }
        
        override public string ToString()
        {
            return string.Format("{0} pressure: {1}", base.ToString(), this._pressure);
        }
    }
}
