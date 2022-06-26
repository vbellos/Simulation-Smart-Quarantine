using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    class smarthome
    {
        public bool Lights { get => Properties.Settings.Default.Lights; set => Properties.Settings.Default.Lights = value; }
        public bool Radio { get => Properties.Settings.Default.Radio; set => Properties.Settings.Default.Radio = value; }
        public bool Tv { get => Properties.Settings.Default.TV; set => Properties.Settings.Default.TV = value; }
        public bool Coffee { get => Properties.Settings.Default.Coffee; set => Properties.Settings.Default.Coffee =  value; }
        public bool Boiler { get => Properties.Settings.Default.Boiler; set => Properties.Settings.Default.Boiler  = value; }
        public double Thermostat { get => Properties.Settings.Default.Thermostat; set => Properties.Settings.Default.Thermostat = value; }
    }
}
