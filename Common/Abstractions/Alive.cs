namespace sandbox.Common.Abstractions {
    internal abstract class Alive {

        private string _name;

        public abstract string Name {
            get; set;
        }

        public abstract void Move();

        public void Breath() { }
    }
}
