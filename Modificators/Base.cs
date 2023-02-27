namespace Modificators {
    public class Base {
        public const int _const = 0;
        public readonly int Age;
        public string Name {
            get;
            private set;
        }

        public string SecondName { get; init; }

        public Base() {
            Name = "Name from private set";
            SecondName = "Second Name";
        }
        public Base(int age) {
            Age = age;
        }

        public virtual void Print() {
            Console.WriteLine("Base:");
        }
    }
}
