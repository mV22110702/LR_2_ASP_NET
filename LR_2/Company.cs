namespace LR_2
{
    public class Company
    {
        public string Name { get; set; }
        public string[] Products { get; set; }
        public double NumberOfEmployees { get; set; }
        public FinancialReport FinancialReport { get;set;}

        public Company() {
            Name = string.Empty;
            Products= new string[0];
            NumberOfEmployees = 0;
            FinancialReport= new FinancialReport();
        }
    }
}
