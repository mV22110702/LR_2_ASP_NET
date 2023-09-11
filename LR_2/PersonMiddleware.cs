using Microsoft.AspNetCore.Http;
using System.Text;

namespace LR_2
{
    public class PersonMiddleware
    {
        private readonly RequestDelegate next;
        private readonly Person person;

        public PersonMiddleware(
            RequestDelegate next,
            Person person
        )
        {
            this.next = next;
            this.person = person;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append($"<h2>Person</h2>");
            stringBuilder.Append($"<p>First name: {person.FirstName}</p>");
            stringBuilder.Append($"<p>Last name: {person.LastName}</p>");
            stringBuilder.Append($"<p>Age: {person.Age}</p>");
            stringBuilder.Append($"<p>University: {person.University}</p>");
            await context.Response.WriteAsync(stringBuilder.ToString());
            context.Response.StatusCode = StatusCodes.Status200OK;

            await next(context);
        }
    }
}
