//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
namespace sandbox.Common
{
    internal class Animal
    {
        public virtual void Jump() { Console.WriteLine("Jump from Animal class"); }
        public void Run() { Console.WriteLine("run"); }
    }

    internal class Dog : Animal
    {
        public override void Jump()
        {
            Console.WriteLine("Jump from Dog class");
        }
    }

    internal class Cat : Animal
    {
        public new void Jump() { Console.WriteLine("Jump from Cat class"); }
        public new void Run() { Console.WriteLine("run from Cat"); }

    }

}
