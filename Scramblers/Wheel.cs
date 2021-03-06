using Enigma.Models;

namespace Enigma.Scramblers
{
    public class Wheel
    {

        CharacterModel[] CharList;

        public int Offset
        {
            get; private set;
        }

        public Wheel(CharacterModel[] CharList)
        {
            this.CharList = CharList;
            Offset = 0;
        }

        public bool StepWheel()
        {
            if(Offset == CharList.Length)
            {
                Offset = 0;
                return false;
            }
            Offset++;
            return true;
        }

        public void ResetOffset()
        {
            Offset = 0;
        }

        private int FindPosition(CharacterModel character)
        {
            for (var i = 0; i < CharList.Length; i++)
            {
                if (CharList[i] == character)
                {
                    return i;
                }
            }

            return -1;
        }

        public char Scramble(char a)
        {
            var character = CharList.Where(item => item.FirstCharacter == a || item.SecondCharacter == a).First();

            int listPosition = FindPosition(character);
            int returnPosition = 0;

            if(listPosition + Offset >= CharList.Length)
            {
                returnPosition = (listPosition + Offset) - CharList.Length;
            }
            else
            {
                returnPosition = listPosition + Offset;
            }


            return a == character.FirstCharacter ? CharList[returnPosition].SecondCharacter : CharList[returnPosition].FirstCharacter;
        }

        public char Descramble(char a)
        {
            var character = CharList.Where(item => item.FirstCharacter == a || item.SecondCharacter == a).First();

            int listPosition = FindPosition(character);
            int returnPosition = 0;

            if(listPosition - Offset < 0)
            {
                returnPosition = CharList.Length + (listPosition - Offset);
            }
            else
            {
                returnPosition = listPosition - Offset;
            }
            return a == character.FirstCharacter ? CharList[returnPosition].SecondCharacter : CharList[returnPosition].FirstCharacter;
        }
    }
}
