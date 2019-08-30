namespace Db4o.Tutorial.Core.F1.Chapter10
{
    public class Car
    {
        string _model;
        Pilot _pilot;
        
        public Car(string model, Pilot pilot)
        {
            this._model = model;
            this._pilot = pilot;
        }
      
        public Pilot Pilot
        {
            get
            {
                return this._pilot;
            }
            
            set
            {
                this._pilot = value;
            }
        }
        
        public string Model         
        {
            get
            {
                return this._model;
            }
        }
        
        override public string ToString()
        {
			return string.Format("{0}[{1}]", this._model, this._pilot);
        }
    }
}
