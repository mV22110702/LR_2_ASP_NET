namespace LR_2
{
    public class CompanyService
    {
        public double CalculateEmployeesSum(List<Company> companies)
        {
            return companies.Aggregate(0D, (temp, x) => x.NumberOfEmployees + temp);
        }
        public Company? MaxEmployees(List<Company> companies)
        {
            return companies.MaxBy(x => x.NumberOfEmployees);
        }
    }
}
