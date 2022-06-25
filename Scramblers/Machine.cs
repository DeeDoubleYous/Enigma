using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Scramblers
{
    public class Machine
    {

        private Wheel[] Wheels;


        public Machine(Wheel[] Wheels)
        {
            this.Wheels = Wheels;
        }

        private void ResetWheels()
        {
            foreach(var wheel in Wheels)
            {
                wheel.ResetOffset();
            }
        }

        private void SpinWheels()
        {
            foreach(var wheel in Wheels)
            {
                if (wheel.StepWheel())
                {
                    break;
                }
            }
        }

        public string Encode(string sentance)
        {
            ResetWheels();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach (char character in sanitizedInput)
            {
                output = output.Append(Wheels[0].Scramble(character));
                if(character != ' ')
                {
                    SpinWheels();
                }
            }

            return output.ToString();
        }

        public string Decode(string sentance)
        {
            ResetWheels();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach(char character in sanitizedInput)
            {
                output = output.Append(Wheels[0].Descramble(character));
                if(character != ' ')
                {
                    SpinWheels();
                }
            }

            return output.ToString();
        }

    }
}
