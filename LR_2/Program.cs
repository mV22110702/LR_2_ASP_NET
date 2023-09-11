using LR_2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var companyService = new CompanyService();

builder.Configuration.AddJsonFile("microsoft.json");
var microsoftCompany = builder.Configuration.Get<Company>();

builder.Configuration.AddXmlFile("apple.xml");
var appleCompany = builder.Configuration.Get<Company>();

builder.Configuration.AddIniFile("google.ini");
var googleCompany = builder.Configuration.Get<Company>();

builder.Configuration.AddJsonFile("person.json");
var person = builder.Configuration.Get<Person>();

app.UseMiddleware<CompaniesMiddleware>(new List<Company> { microsoftCompany, appleCompany, googleCompany }, companyService);
app.UseMiddleware<PersonMiddleware>(person);

app.Run();
