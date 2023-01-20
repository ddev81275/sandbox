using sandbox.Common;

var hero = new Hero();
var car = new Car();
var isType = car is Hero;

Console.WriteLine(isType);
Console.WriteLine(car is null);
