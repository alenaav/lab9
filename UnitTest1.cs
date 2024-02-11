using lab9_2;
namespace TestDialClockArray;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        DialClockArray d = new DialClockArray(5);
        //Act
        Assert.ThrowsException<Exception>(() => { new DialClock(d[10]); });
    }
    [TestMethod]
    public void TestMethod2()
    {
        DialClockArray expected = new DialClockArray();
        Assert.AreEqual(0, expected.Length);
    }
    [TestMethod]
    public void TestMethod3()
    {
        //Arrange
        DialClockArray expected = new DialClockArray(3);
        expected[0] = new DialClock(5, 3);
        expected[1] = new DialClock(15, 12);
        expected[2] = new DialClock(0, 9);
        //Act
        DialClockArray actual = new DialClockArray(expected);
        //Assert
        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
        Assert.AreEqual(expected[2], actual[2]);
    }
}