namespace AdapterExample
{
    /// <summary>
    /// Clase Adapter
    /// </summary>

    public class Adapter: ISmartDevice
    {
        /// <summary>
        /// Propiedad plug.
        /// </summary>
        public Plug plug{get;set;}

        /// <summary>
        /// Constructor de Adapter.
        /// </summary> 
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        /// <summary>
        /// Método prender estado.
        /// </summary>
        public void On()
        {
            if(this.plug.GetStatus() == "off")
            {
                this.plug.ToggleStatus();
            }
        }
        /// <summary>
        /// Método apagar estado.
        /// </summary>
        public void Off()
        {
            if(this.plug.GetStatus() == "on")
            {
                this.plug.ToggleStatus();
            }
        }
        /// <summary>
        /// Obtener el estado.
        /// </summary>
        public string GetStatus()
        {
            return this.plug.GetStatus();
        }



    }
}