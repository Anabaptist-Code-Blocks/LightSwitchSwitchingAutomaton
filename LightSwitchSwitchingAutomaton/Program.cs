
using System;
using System.Linq;

var lights = new bool[100];
for (int person = 1; person <= 100; person++)
{
    for (int sw = 0; sw < lights.Length; sw += person)
        lights[sw] = !lights[sw];

    Console.WriteLine($"Person: {person:0##} Lights On: {lights.Count(l => l):0##} Lights Off: {lights.Count(l => !l):0##} Lights: {string.Join(" ", lights.Select(l => l ? "1" : "0"))}");
}

Console.WriteLine($"Light number 49 is {(lights[48] ? "On" : "Off")}");
Console.ReadLine();
