namespace AdapterExample
{
    public class Adapter: ISmartDevice
    {
        public Plug plug{get;set;}
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        public void On()
        {
            if(this.plug.GetStatus() == "off")
            {
                this.plug.ToggleStatus();
            }
        }
        public void Off()
        {
            if(this.plug.GetStatus() == "on")
            {
                this.plug.ToggleStatus();
            }
        }
        public string GetStatus()
        {
            return this.plug.GetStatus();
        }



    }
}