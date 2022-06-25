namespace Enigma.Models
{
    public class CharacterModel
    {
        public char FirstCharacter
        {
            get;
        }

        public char SecondCharacter
        {
            get;
        }

        public CharacterModel(char FirstCharacter, char SecondCharacter)
        {
            this.FirstCharacter = FirstCharacter;
            this.SecondCharacter = SecondCharacter;
        }
    }
}
