using Enigma.Scramblers;
using Enigma.Models;

CharacterModel[] firstSetting =
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

CharacterModel[] secondSettings =
{
    new CharacterModel('a', 'f'),
    new CharacterModel('o', 'y'),
    new CharacterModel('u', 'i'),
    new CharacterModel('p', 'd'),
    new CharacterModel('e', 'q'),
    new CharacterModel('b', 'c'),
    new CharacterModel('m', 'z'),
    new CharacterModel('x', 'g'),
    new CharacterModel('j', 'h'),
    new CharacterModel('k', 'v'),
    new CharacterModel('l', 'n'),
    new CharacterModel('r', 't'),
    new CharacterModel('s', 'w')
};

Wheel[] wheel = { new Wheel(firstSetting), new Wheel(secondSettings) };

var machine = new Machine(wheel);

Console.WriteLine(machine.Encode("This is the dawning of the age of aquarious"));
Console.WriteLine(machine.Decode("xtdv lz zol ldcntgf yw nrq fux pa rvuptdxti"));