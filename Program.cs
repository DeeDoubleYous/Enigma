using Enigma.Scramblers;
using Enigma.Models;

CharacterModel[] setting =
{
    new CharacterModel('a', 'z'),
    new CharacterModel('b', 'y'),
    new CharacterModel('c', 'x'),
    new CharacterModel('d', 'w'),
    new CharacterModel('e', 'v'),
    new CharacterModel('f', 'u'),
    new CharacterModel('g', 't'),
    new CharacterModel('h', 's'),
    new CharacterModel('i', 'r'),
    new CharacterModel('j', 'q'),
    new CharacterModel('k', 'p'),
    new CharacterModel('l', 'o'),
    new CharacterModel('m', 'n')
};

var wheel = new Wheel(setting);

var machine = new Machine(wheel);

Console.WriteLine(machine.Encode("Hello World"));
Console.WriteLine(machine.Decode("suzyc iectn"));