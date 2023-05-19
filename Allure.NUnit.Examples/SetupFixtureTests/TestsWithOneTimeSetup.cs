using NUnit.Framework;

namespace Allure.NUnit.Examples.SetupFixtureTests;

public class TestsWithOneTimeSetup : BaseTest
{
    [Test]
    public void Test1()
    {
        PizzaStepsExamples.CookPizza();
    }
    
    [Test]
    public void Test2()
    {
        PizzaStepsExamples.DeliverPizza();
    }
}
