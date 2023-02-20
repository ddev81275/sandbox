namespace yield_test {
    public class NewOverride {
        public virtual void Say() {
            Console.WriteLine("Hello from base class");
        }
    }

    public class DeliveredOne : NewOverride {

        public DeliveredOne() : base() { }

        public override void Say() {
            base.Say();
            //Console.WriteLine("Hello from delivered class");
        }
    }

    public class DeliveredTwo : NewOverride {
        public new void Say() {
            Console.WriteLine("Hide base method");
        }
    }
}
