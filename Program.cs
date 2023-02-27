using Modificators;

Base _base = new Base();
Base _b = new Base(100);

Console.WriteLine($"Name: {_base.Name}");
Console.WriteLine($"Second Name: {_base.SecondName}");
Console.WriteLine($"Age: {_base.Age}");
Console.WriteLine($"const: {Base._const}");

Console.WriteLine(new Base(1000).Age);