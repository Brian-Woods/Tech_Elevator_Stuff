using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }

        public int CurrentChannel { get; private set; }

        public int CurrentVolume { get; private set; }

        public Television()
        {
          IsOn = false;

          CurrentChannel = 3;

          CurrentVolume = 2;
        }


        public void TurnOff()
        {
            IsOn = false;
            
        }

        public void TurnOn()
        {
            IsOn = true;
            
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn == true)
            {
            

                if (newChannel > 2 && newChannel < 18)
                {
                    CurrentChannel = newChannel;
                }
                
            }
            
        }

        public void ChannelUp()
        {
            if (IsOn == true)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 2;
                }
                if (CurrentChannel < 18)
                {
                    CurrentChannel++;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn == true)
            {

                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }

                else if (CurrentChannel > 3)
                {
                    CurrentChannel--;
                }

               

                




            }
        }

        public void RaiseVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume < 10)
                {
                    CurrentVolume++;
                }
            }
        }

        public void LowerVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume--;
                }
            }
        }





    }
}
