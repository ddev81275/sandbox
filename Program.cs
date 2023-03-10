var baseClass = new BaseClass();
var delivered = new Delivered();
BaseClass _d = new Delivered();



baseClass.Say();
Console.WriteLine(delivered.Say());
_d.Say();

public class BaseClass {
    public virtual void Say() {
        Console.WriteLine("Say from Base");
    }
}

public class Delivered : BaseClass {
    public new int Say() {
        return 0;
    }
}