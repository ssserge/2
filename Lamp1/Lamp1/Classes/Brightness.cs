using Lamp1.Enum;
using Lamp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp1.Classes
{
    class Brightness : IBrightness
    {
        
        private Level brightness;
        public Brightness(Level mode)
        {
            brightness = mode;
        }

        public void LowBrightness()
        {
            brightness = Level.Low;
        }

        public void MediumBrightness()
        {
            brightness = Level.Medium;
        }

        public void HighBrightness()
        {
            brightness = Level.High;
        }

        public override string ToString()
        {            
            string mode;
            if (this.brightness == Level.Low)
            {
                mode = "слабая";
            }
            else if (this.brightness == Level.Medium)
            {
                mode = "средняя";
            }
            else
            {
                mode = "высокая";
            }

            return "яркость: " + mode;
        }


    }
}
