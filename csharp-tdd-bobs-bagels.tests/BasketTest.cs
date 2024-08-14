using csharp_tdd_bobs_bagels.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTest
{

    [Test]
    public void AddBagelTest()
    {
        Basket basket = new();
        basket.basket.Capacity = 1;
        string bagel = "Bagel";

        var result = basket.Add(bagel);

        Assert.That(result, Is.True);
    }
    [Test]
    public void AddBagelExistsTest()
    {
        Basket basket = new();
        basket.basket.Capacity = 1;
        string bagel = "Bagel";

        var result = basket.Add(bagel);

        Assert.That(basket.basket.Contains(bagel), Is.True);
    }

    [Test]
    public void RemoveBagelTest()
    {
        Basket basket = new();
        basket.basket.Capacity = 1;
        string bagel = "Bagel";

        basket.Add(bagel);
        var result = basket.Remove(bagel);

        Assert.That(result, Is.True);
    }
    [Test]
    public void AddingBagelBeyondCapacityTest()
    {
        Basket basket = new();
        basket.basket.Capacity = 1;
        string bagel = "Bagel";
        string specialBagel = "specialBagel";

        var result1 = basket.Add(bagel);
        var result2 = basket.Add(specialBagel);

        Assert.That(result1, Is.True);
        Assert.That(result2, Is.False);
    }

    [Test]
    public void ChangeCapacityTest()
    {
        Basket basket = new();
        int initialCapacity = 1;
        int changedCapacity = 2;

        basket.basket.Capacity = initialCapacity;

        basket.basket.Capacity = changedCapacity;

        Assert.That(changedCapacity, Is.EqualTo(basket.basket.Capacity));
    }
}