namespace sandbox.Common {
    public class Hero {
        public void Kick() {
            Console.WriteLine("Bang-bang");
        }
    }
    public class AllMight : Hero {
        new public void Kick() {
            Console.WriteLine("One 2 All");
        }

        public virtual void Jump() {
            Console.WriteLine("Jump as AllMight");
        }
    }

    public class Deku : AllMight {
        public override void Jump() {
            base.Jump();
            Console.WriteLine("Jump as Deku");
        }
    }
}
