using System.IO;
using Tyuiu.KislayaVA.Sprint6.Task5.V7.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\Вера Кислая\\source\\repos\\Tyuiu.KislayaVA.Sprint6\\Files\\TestDataTask5.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20.45 };
            Assert.AreEqual(res.Length, wait.Length);
            Assert.AreEqual(res[1], wait[1]);
        }
    }
}
