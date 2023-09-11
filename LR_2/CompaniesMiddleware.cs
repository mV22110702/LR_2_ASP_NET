using System.Text;
namespace LR_2
{
    public class CompaniesMiddleware
    {
        private readonly RequestDelegate next;
        private readonly List<Company> companies;
        private readonly CompanyService companyService;

        public CompaniesMiddleware(
            RequestDelegate next,
            List<Company> companies,
            CompanyService companyService
        )
        {
            this.next = next;
            this.companies = companies;
            this.companyService = companyService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            var employeesSum = this.companyService.CalculateEmployeesSum(this.companies);
            var maxEmployeeCountCompany = this.companyService.MaxEmployees(this.companies);

            StringBuilder stringBuilder = new();
            stringBuilder.Append($"<h2>Company stats</h2>");
            stringBuilder.Append($"<p>Employees sum: {employeesSum}</p>");
            stringBuilder.Append($"<p>Employee max count: {maxEmployeeCountCompany.NumberOfEmployees} ({maxEmployeeCountCompany.Name})</p>");

            await context.Response.WriteAsync(stringBuilder.ToString());

            await next(context);

            context.Response.StatusCode = StatusCodes.Status200OK;
        }
    }
}
