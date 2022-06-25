using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Scramblers
{
    public class Machine
    {

        private Wheel Wheel1;


        public Machine(Wheel Wheel1)
        {
            this.Wheel1 = Wheel1;
        }

        public string Encode(string sentance)
        {
            Wheel1.ResetOffset();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach (char character in sanitizedInput)
            {
                output = output.Append(Wheel1.Scramble(character));
            }

            return output.ToString();
        }

        public string Decode(string sentance)
        {
            Wheel1.ResetOffset();

            var output = new StringBuilder();

            var sanitizedInput = sentance.ToLower().ToCharArray();

            foreach(char character in sanitizedInput)
            {
                output = output.Append(Wheel1.Descramble(character));
            }

            return output.ToString();
        }

    }
}
