namespace CommandConsoleMenu
{
    public class Illuminator
    {
        private bool state;
        //private BrightnessLevel brightness;
        private ILevel level;

        public Illuminator(bool state, ILevel mod)
        {
            this.state = state;
            //this.brightness = mode;
            level = mod;
        }

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        //public void SetLowBrightness()
        //{
        //    brightness = BrightnessLevel.Low;
        //}

        //public void SetMediumBrightness()
        //{
        //    brightness = BrightnessLevel.Medium;
        //}

        //public void SetHighBrightness()
        //{
        //    brightness = BrightnessLevel.High;
        //}

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

            //string mode;
            //if (/*this.brightness*/level == BrightnessLevel.Low)
            //{
            //    mode = "слабая";
            //}
            //else if (this.brightness == BrightnessLevel.Medium)
            //{
            //    mode = "средняя";
            //}
            //else
            //{
            //    mode = "высокая";
            //}

            return "состояние: " + state + ", яркость: "/* + mode*/;
        }
    }

    public interface ILevel
    {
        void Low();
        void Medium();
        void High();
    }

    public class Level : ILevel
    {
        public BrightnessLevel level;
        public Level(BrightnessLevel mod)
        {
            this.level = mod;
        }

        public void Low()
        {
            level = BrightnessLevel.Low;
        }

        public void Medium()
        {
            level = BrightnessLevel.Medium;
        }

        public void High()
        {
            level = BrightnessLevel.High;
        }

        public override string ToString()
        {
            string mod;
            if (this.level == BrightnessLevel.Low)
            {
                mod = "слабая";
            }
            else if (this.level == BrightnessLevel.Medium)
            {
                mod = "средняя";
            }
            else
            {
                mod = "высокая";
            }

            return "Яркость: " + mod;
        }

    }
}
