namespace Db4o.Tutorial.Core.F1.Chapter9
{
  using System;

  using Activation;

  public class TemperatureSensorReadout : SensorReadout
    {
        private readonly double _temperature;

        public TemperatureSensorReadout(DateTime time, Car car, string description, double temperature)
            : base(time, car, description)
        {
            this._temperature = temperature;
        }

        public double Temperature
        {
            get
            {
				this.Activate(ActivationPurpose.Read);
                return this._temperature;
            }
        }

        public override String ToString()
        {
			this.Activate(ActivationPurpose.Read);
            return string.Format("{0} temp : {1}", base.ToString(), this._temperature);
        }
    }
}