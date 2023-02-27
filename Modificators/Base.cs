using Modificators.Interface;

namespace Modificators {
    public class Base : IDoable {
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

        public virtual void SayAnything() {
            Console.WriteLine("Sayanithing");
        }
        public virtual void Hello() {
            Console.WriteLine("Hello from Base class");
        }
    }

    public class D : Base {
        public override void SayAnything() {
            base.SayAnything();
        }

        public override void Hello() {
            Console.WriteLine("Hello from D class");
        }
    }
}
