using sandbox.Common;

var car = new Car();
var nissanV2 = new Nissan();
var bmw = new BMW();

Nissan? nissan = car as Nissan;
Fiat? fiat = car as Fiat;
Stellantis? stellantis = car as Stellantis;

Console.WriteLine(car is Nissan);
Console.WriteLine(car is Fiat);
Console.WriteLine(car is Stellantis);
Console.WriteLine(nissanV2 is Car);
Console.WriteLine(car is BMW);