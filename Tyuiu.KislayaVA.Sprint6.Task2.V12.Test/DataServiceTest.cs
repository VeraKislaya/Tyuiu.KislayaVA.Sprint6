using Tyuiu.KislayaVA.Sprint6.Task2.V12.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(new double[] { 2.19, 3.31, 2.97, 1.18, 0.03 }, ds.GetMassFunction(1, 5));
        }
    }
}
