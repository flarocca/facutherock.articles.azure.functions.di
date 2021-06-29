using FacuTheRock.Articles.Azure.Functions.DI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace FacuTheRock.Articles.Azure.Functions.DI
{
    public class Greeting
    {
        private readonly IGreetingService _greetingService;

        public Greeting(IGreetingService greetingService) =>
            _greetingService = greetingService;

        [FunctionName("Greeting")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var name = req.Query["name"];
            var greeting = _greetingService.GetGreeting(name);

            return new OkObjectResult(greeting);
        }
    }
}
