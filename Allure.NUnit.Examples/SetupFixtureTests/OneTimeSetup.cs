using NUnit.Framework;

namespace Allure.NUnit.Examples.SetupFixtureTests;

[SetUpFixture]
public class OneTimeSetup
{
    [OneTimeSetUp]
    public void Setup()
    {
        PizzaStepsExamples.PrepareDough();
    }
    
    [OneTimeTearDown]
    public void TearDown()
    {
        PizzaStepsExamples.DeliverPizza();
    }
}
