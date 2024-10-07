using CITest;
using CITest.Models;
using NUnit.Framework;

namespace MyApp.Tests;

public class Tests
{
    
    private Calculator _calculator { get; set; } = null!;
    
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Test_Add_ReturnsAddedNumbers()
    {
        double x = 5, y = 6;
        double sum = _calculator.Add(x, y);
        double trueSum = x + y;
        
        Assert.That(sum == trueSum);
    }
    
    [Test]
    public void Test_Multiply_ReturnsMultipliedNumbers()
    {
        double x = 5, y = 6;
        double sum = _calculator.Multiply(x, y);
        double trueSum = x * y;
        
        Assert.That(sum == trueSum);
    }
}