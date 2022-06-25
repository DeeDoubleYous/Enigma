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

        private char Scramble(char a)
        {
            if(a == ' ')
            {
                return ' ';
            }

            char store = a;

            foreach(var wheel in Wheels)
            {
                store = wheel.Scramble(store);
            }

            SpinWheels();

            return store;
        }

        private char Descramble(char a)
        {
            if (a == ' ')
            {
                return ' ';
            }

            char store = a;

            foreach(var wheel in Wheels)
            {
                store = wheel.Descramble(store);
            }

            SpinWheels();

            return store;
        }

        public string Encode(string sentance)
        {
            ResetWheels();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            var output = sanitizedInput.Select(a => Scramble(a)).ToArray();

            return new string(output);
        }

        public string Decode(string sentance)
        {
            ResetWheels();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            var output = sanitizedInput.Select(a => Descramble(a)).ToArray();

            return new string(output);
        }

    }
}
