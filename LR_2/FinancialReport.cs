namespace LR_2
{
    public class FinancialReport
    {
        public double Equity { get; set; }
        public double Turnover { get; set; }
        public double RAndDExpenses { get; set; }
        public double OperatingIncome { get; set; }
        public double NetIncome { get; set; }
        public double Assets { get; set; }
        public double Capitalization { get; set; }

        public FinancialReport()
        {
            Equity = 0.0;
            Turnover = 0.0;
            RAndDExpenses = 0.0;
            OperatingIncome = 0.0;
            NetIncome = 0.0;
            Assets = 0.0;
            Capitalization = 0.0;
        }
    }
}
