namespace sandbox.Common
{
    public class Hero
    {
        public string Name { get; set; }

        public virtual void Kick()
        {
            Console.WriteLine("Bang-bang");
        }
    }
    public class AllMight : Hero
    {
        public virtual decimal Height { get; set; }
        public override void Kick()
        {
            Console.WriteLine("One 2 All");
            //base.Kick();
        }
    }

    public class Deku : AllMight
    {
        public sealed override decimal Height { get; set; }
        public override void Kick()
        {
            base.Kick();
        }
    }

    public class Juniour : AllMight
    {
        public Juniour() : base() { }
    }

}
