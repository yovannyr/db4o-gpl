namespace Db4o.Tutorial.Core.F1.Chapter9
{
  using System;

  using Activation;

  using Db4o;

  using TA;

  public class Car : IActivatable 
{
    private readonly String _model;
    private SensorReadout _history;
    
    [Transient]
    private IActivator _activator;

    public Car(String model) 
    {
        this._model=model;
        this._history=null;
    }

    public String Model
    {
        get
        {
			this.Activate(ActivationPurpose.Read);
            return this._model;
        }
    }
    
    public SensorReadout History
    {
        get
        {
			this.Activate(ActivationPurpose.Read);
            return this._history;
        }
    }
    
    public void snapshot() 
    {   
        this.AppendToHistory(new TemperatureSensorReadout(DateTime.Now,this,"oil", this.PollOilTemperature()));
        this.AppendToHistory(new TemperatureSensorReadout(DateTime.Now, this, "water", this.PollWaterTemperature()));
    }

    protected double PollOilTemperature() 
    {
	    return 0.1* this.CountHistoryElements();
    }

    protected double PollWaterTemperature() 
    {
        return 0.2* this.CountHistoryElements();
    }

    public override String ToString() 
    {
		this.Activate(ActivationPurpose.Read);
        return string.Format("{0}/{1}", this._model, this.CountHistoryElements());
    }
    
    private int CountHistoryElements() 
    {
		this.Activate(ActivationPurpose.Read);
        return (this._history==null ? 0 : this._history.CountElements());
    }
    
    private void AppendToHistory(SensorReadout readout) 
    {
		this.Activate(ActivationPurpose.Write);
        if(this._history==null) 
        {
            this._history=readout;
        }
        else 
        {
            this._history.Append(readout);
        }
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