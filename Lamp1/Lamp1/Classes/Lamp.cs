using Lamp1.Enum;
using Lamp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp1.Classes
{
    class Lamp
    {
        private IState state;
        private IBrightness brightness;

        public Lamp(IState state, IBrightness mod)
        {
            this.state = state;
            brightness = mod;
        }

        public override string ToString ()
        {           
            return state.ToString() + brightness.ToString();
        }
    }
}
