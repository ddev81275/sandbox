using sandbox.Cast;

////Manager manager= new Manager();
////Employee employee = manager as Employee;

//Employee employee = new Employee();
//var isManager = employee is Manager;
////Manager? manager = employee as Manager;

////Console.WriteLine(employee);
////Console.WriteLine(manager);
//Console.WriteLine(isManager);

Director director= new Director();
var employee = director as Employee;

Console.WriteLine(employee);

var emp = new Employee();
Director? dir = emp as Director;
Console.WriteLine(dir);