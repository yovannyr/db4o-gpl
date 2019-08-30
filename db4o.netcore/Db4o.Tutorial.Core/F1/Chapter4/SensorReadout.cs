namespace Db4o.Tutorial.Core.F1.Chapter4
{
  using System;
  using System.Text;

  public class SensorReadout
    {
        double[] _values;
        DateTime _time;
        Car _car;
        
        public SensorReadout(double[] values, DateTime time, Car car)
        {
            this._values = values;
            this._time = time;
            this._car = car;
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
        
        public int NumValues
        {
            get
            {
                return this._values.Length;
            }
        }
        
        public double[] Values
        {
        	get
        	{
        		return this._values;
        	}
        }
        
        public double GetValue(int idx)
        {
            return this._values[idx];
        }
        
        override public string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this._car);
            builder.Append(" : ");
            builder.Append(this._time.TimeOfDay);
            builder.Append(" : ");
            for (int i=0; i<this._values.Length; ++i)
            {
                if (i > 0)
                {
                    builder.Append(", ");
                }
                builder.Append(this._values[i]);
            }
            return builder.ToString();
        }
    }
}
