namespace Modificators.Bank {
    public class Account {
        internal string _Interanal = "Hello from internal";
        private static double _depositVal = 10.4;

        public double DepositValue { get; }

        public double CalculateSum(double income) {
            return DepositValue * income;
        }
    }
}
