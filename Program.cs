using Modificators;

Delivered delivered = new Delivered();
Base _b = new Base();   

var _base = (Base)delivered;
var _d = (Delivered)_b;
//var _d = _b as Delivered;


Console.WriteLine($"{_b} {_b is Base}");
Console.WriteLine($"{_d} {_d is Delivered}");