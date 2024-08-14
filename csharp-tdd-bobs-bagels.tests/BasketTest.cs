using csharp_tdd_bobs_bagels.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTest
{


    [Test]
    public void AddBagelTest()
    {
        Basket basket = new();
        string bagel = "Bagel";

        var result = basket.Add(bagel);

        Assert.That(result, Is.True);
    }
}