namespace Db4o.Tutorial.Core.F1.Chapter9
{
  using System;

  using Activation;

  using Db4o;

  using TA;

  public class SensorReadout : IActivatable
    {
        private readonly DateTime _time;
        private readonly Car _car;
        private String _description;
        private SensorReadout _next;

        [Transient] 
        private IActivator _activator;

        protected SensorReadout(DateTime time, Car car, String description)
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
                this.Activate(ActivationPurpose.Read);
                return this._car;
            }
        }

        public DateTime Time
        {
            get
            {
                this.Activate(ActivationPurpose.Read);
                return this._time;
            }
        }

        public String Description
        {
            get
            {
                this.Activate(ActivationPurpose.Read);
                return this._description;
            }
            set
            {
                this.Activate(ActivationPurpose.Write);
                this._description = value;
            }
        }

        public SensorReadout Next
        {
            get
            {
                this.Activate(ActivationPurpose.Read);
                return this._next;
            }
        }

        public void Append(SensorReadout readout)
        {
            this.Activate(ActivationPurpose.Write);
            if (this._next == null)
            {
                this._next = readout;
            }
            else
            {
                this._next.Append(readout);
            }
        }

        public int CountElements()
        {
            this.Activate(ActivationPurpose.Read);
            return (this._next == null ? 1 : this._next.CountElements() + 1);
        }

        public override String ToString()
        {
            this.Activate(ActivationPurpose.Read);
            return String.Format("{0} : {1} : {2}", this._car, this._time, this._description);
        }

        public void Activate(ActivationPurpose purpose)
        {
            if (this._activator != null)
            {
                this._activator.Activate(purpose);
            }
        }

        public void Bind(IActivator activator)
        {
            if (this._activator == activator)
            {
                return;
            }
            if (activator != null && null != this._activator)
            {
                throw new System.InvalidOperationException();
            }
            this._activator = activator;
        }
    }
}