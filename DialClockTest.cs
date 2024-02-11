using lab9_2;
namespace TestDialClock;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        DialClock expected = new DialClock(13, 5);
        //Act
        DialClock actual = new DialClock(12, 65);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod2()
    {
        //Arrange
        DialClock expected = new DialClock(12, 10);
        //Act
        DialClock actual = new DialClock(expected);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod3()
    {
        //Arrange
        DialClock expected = new DialClock();
        //Act
        DialClock actual = new DialClock();
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod4()
    {
        //Arrange
        DialClock expected = new DialClock(12, 41);
        //Act
        DialClock actual = new DialClock(expected);
        //Assert
        Assert.AreEqual(expected.CalculateAngle(), actual.CalculateAngle());
    }
    [TestMethod]
    public void TestMethod5()
    {
        //Arrange
        DialClock expected = new DialClock(12, 30);
        expected++;
        //Act
        DialClock actual = new DialClock(13, 30);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod6()
    {
        //Arrange
        DialClock expected = new DialClock(12, 30);
        expected--;
        //Act
        DialClock actual = new DialClock(12, 29);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod7()
    {
        //Arrange
        DialClock expected = new DialClock(12, 41);
        //Act
        DialClock actual = new DialClock(expected);
        //Assert
        Assert.AreEqual((bool)expected, (bool)actual);
    }
    [TestMethod]
    public void TestMethod8()
    {
        //Arrange
        DialClock expected = new DialClock(12, 38);
        //Act
        DialClock actual = new DialClock(expected);
        //Assert
        Assert.AreEqual((int)expected, (int)actual);
    }
    [TestMethod]
    public void TestMethod9()
    {
        //Arrange
        DialClock expected = new DialClock(0, 0);
        //Act
        DialClock actual = new DialClock(-2, -2);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod10()
    {
        //Arrange
        DialClock expected = new DialClock(1, 30);
        //Act
        DialClock actual = new DialClock(25, 30);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod11()
    {
        //Arrange
        DialClock expected = new DialClock(12, 41);
        //Act
        DialClock actual = new DialClock(expected);
        //Assert
        Assert.AreEqual(DialClock.CalculateAngleStatic(expected.Hours, expected.Minutes), DialClock.CalculateAngleStatic(actual.Hours, actual.Minutes));
    }
}
