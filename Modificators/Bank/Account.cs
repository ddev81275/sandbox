namespace Modificators.Bank {
    public class Account {
        private static double _depositVal = 10.4;

        public double DepositValue { get; }

        public double CalculateSum(double income) {
            return DepositValue * income;
        }
    }
}
