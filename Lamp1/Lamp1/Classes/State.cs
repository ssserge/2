using Lamp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp1.Classes
{
    class State : IState
    {
        private bool state;
        public State(bool state)
        {
            this.state = state;
        }

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        public override string ToString()
        {
            string state;
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }           
            return "состояние: " + state;
        }
    }
}
