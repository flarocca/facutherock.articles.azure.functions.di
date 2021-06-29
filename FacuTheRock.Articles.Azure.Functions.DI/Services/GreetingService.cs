namespace FacuTheRock.Articles.Azure.Functions.DI.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting(string name) =>
            string.IsNullOrEmpty(name)
                ? "Hi there!"
                : $"Hi {name}!";
    }
}
