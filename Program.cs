using Modificators;
using Modificators.Interface;

Base b = new Base();
D d = new D();
IDoable ib = new Base();
IDoable id = new D();


//b.Hello();
//d.Hello();

//ib.Hello();
//id.Hello(); 

Console.WriteLine(d is IDoable);
Console.WriteLine(b is IDoable);

Console.WriteLine(id is Base);