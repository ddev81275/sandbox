namespace sandbox.OneClassIntoOther {
    internal class Bottle {
        private decimal _capacity = 0.5M;
        //private int myVar;

        //public int MyProperty {
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        public decimal Capacity {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public void GetBottleName() {
            Console.WriteLine("Tassai");
        }
    }
}
