// See https://aka.ms/new-console-template for more information
using CalcExample;
Calc calc = new Calc();

Console.WriteLine("Add Call");
calc.Add(12, 45);
Console.WriteLine("Multi Call");
calc.Multi(12.5, 13.5);
Console.WriteLine("Div Call");
calc.Div(20, 4);
Console.WriteLine("Sub Call");
calc.Sub(20, 4);