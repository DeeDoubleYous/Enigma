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

Wheel[] wheel = { new Wheel(setting), new Wheel(setting), new Wheel(setting) };

var machine = new Machine(wheel);

Console.WriteLine(machine.Encode("This is the dawning of the age of aquarious"));
Console.WriteLine(machine.Decode("grpk nm myn npblrar bq lzo rxy jv zkhwmzemc"));