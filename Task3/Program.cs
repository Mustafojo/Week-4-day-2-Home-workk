using System.Runtime.CompilerServices;

var lamp = new Lamp();
var command = Console.ReadLine();
if (command == "on")
{
    lamp.TurnOn();
}
else if(command == "off")
{
    lamp.TurnOff();
}
else
{
    lamp.Vayron();
}


var loc = new Lock();
var command1 = Console.ReadLine();
if (command1 == "on")
{
    loc.TurnOn();
}
else if(command1 == "off")
{
    loc.TurnOff();
}
else
{
    loc.Vayron();
}


var themostat = new Themostat();
var command2 = Console.ReadLine();
if (command2 == "on")
{
    themostat.TurnOn();
}
else if(command2 == "off")
{
    themostat.TurnOff();
}
else
{
    themostat.Vayron();
}