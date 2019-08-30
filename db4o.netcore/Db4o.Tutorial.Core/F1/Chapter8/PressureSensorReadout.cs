namespace Db4o.Tutorial.Core.F1.Chapter8
{
  using System;

  using Activation;

  public class PressureSensorReadout : SensorReadout
    {
        private readonly double _pressure;

        public PressureSensorReadout(DateTime time, Car car, String description, double pressure)
            : base(time, car, description)
        {
            this._pressure = pressure;
        }

        public double Pressure
        {
            get
            {
				this.Activate(ActivationPurpose.Read);
                return this._pressure;
            }
        }

        override public String ToString()
        {
            return String.Format("{0} pressure {1}", base.ToString(), this._pressure);
        }
    }
}