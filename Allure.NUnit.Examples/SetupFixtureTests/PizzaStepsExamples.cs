using System;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;

namespace Allure.NUnit.Examples.SetupFixtureTests;

public static class PizzaStepsExamples
{
    private static readonly Random Random = new();
    
    [AllureStep("Prepare dough")]
    public static void PrepareDough()
    {
        Method($"Step {nameof(PrepareDough)}");
    }

    [AllureStep("Cook pizza")]
    public static void CookPizza()
    {
        Method($"Step {nameof(CookPizza)}");
    }

    [AllureStep("Deliver")]
    public static void DeliverPizza()
    {
        Method($"Step {nameof(DeliverPizza)}");
    }
    
    [AllureStep("Pay")]
    public static void Pay()
    {
        Method($"Step {nameof(Pay)}");
    }
    
    private static void Method(string message)
    {
        var delay = Random.Next(50, 200);
        Task.Delay(delay).ConfigureAwait(false).GetAwaiter().GetResult();
        Console.WriteLine($"{message}");
    }
}
