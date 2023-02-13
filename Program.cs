//using sandbox.Common;

//string name = "All Might";
//name = "Deku";
//Console.WriteLine(name);

//Animal animal= new Animal();
//animal.Breath();
//Cat cat = new Cat();
//cat.Breath();
//cat.Move();

//using sandbox.Common;

//Hero hero = new Hero();
//hero.Kick();

//AllMight allMight = new AllMight();
//allMight.Kick();

//Deku Deku = new Deku();
//Deku.Kick();
//Deku.Jump();


//using Modificators.Bank;

//Account TomAc = new Account();
//Account JhonAc = new Account();

//var id = Docs.ID;
//var id2 = Docs.ID;

//Console.WriteLine($"{id} {id2}");

using sandbox.Cast;

//Manager manager = new Manager();
//Employee employee = manager as Employee;

//Console.WriteLine(manager is Manager);
//Console.WriteLine(employee is Manager);
//Console.WriteLine(employee is Employee);

Employee employee = new Employee();
Manager manager = employee as Manager;

Console.WriteLine(employee);
Console.WriteLine(manager);