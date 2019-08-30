namespace Db4o.Tutorial.Core.F1.Chapter8
{
  using System;

  using Activation;

  using Db4o;

  using TA;

  public class Pilot : IActivatable
    {
        private readonly String _name;
        private int _points;
        
        [Transient]
        private IActivator _activator;

        public Pilot(String name,int points) 
        {
            this._name=name;
            this._points=points;
        }

        public int Points
        {
            get
            {
				this.Activate(ActivationPurpose.Read);
                return this._points;
            }

            set
            {
				this.Activate(ActivationPurpose.Write);
                this._points += value;
            }
        }

        public String Name
        {
            get
            {
				this.Activate(ActivationPurpose.Read);
                return this._name;
            }
        }

        public override string  ToString()
        {
			this.Activate(ActivationPurpose.Read);
            return String.Format("{0}/{1}", this._name, this._points);
        }
        
        public void Activate(ActivationPurpose purpose) 
        {
            if(this._activator != null) 
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