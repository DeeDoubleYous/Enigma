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


        public string Encode(string sentance)
        {
            Wheels[0].ResetOffset();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach (char character in sanitizedInput)
            {
                output = output.Append(Wheels[0].Scramble(character));
            }

            return output.ToString();
        }

        public string Decode(string sentance)
        {
            Wheels[0].ResetOffset();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach(char character in sanitizedInput)
            {
                output = output.Append(Wheels[0].Descramble(character));
            }

            return output.ToString();
        }

    }
}
