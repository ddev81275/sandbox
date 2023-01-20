namespace sandbox.Common
{
    internal class Car
    {
        internal Car() { }
        internal Car(string name) { Console.WriteLine(name); }
    }

    internal class Nissan : Car
    {
        internal Nissan() : base() { }
        internal Nissan(string name) : base("nissan ctor") { }
    }

    internal class Stellantis : Car
    {
        string Name { get; set; }

        internal Stellantis() : base()
        {
            Name = "Stellantis";
            Console.WriteLine($"Name: {Name}");
        }

        internal Stellantis(string name)
        {
            Name = name;
            Console.WriteLine("Stellantis(string name)");
        }
    }

    internal class Fiat : Stellantis
    {
        internal Fiat() : base() { }
        internal Fiat(string name) : base(name) { }
    }
}
